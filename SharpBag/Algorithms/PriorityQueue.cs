﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpBag.Algorithms
{
    /// <summary>
    /// A priority queue.
    /// </summary>
    /// <typeparam name="T">The type of items in the priority queue.</typeparam>
    public class PriorityQueue<T> : IEnumerable<T>
    {
        /// <summary>
        /// The items.
        /// </summary>
        private List<PriorityQueueItem<T>> Items { get; set; }

        /// <summary>
        /// The constructor.
        /// </summary>
        public PriorityQueue()
        {
            this.Items = new List<PriorityQueueItem<T>>();
        }

        /// <summary>
        /// Adds an item to the queue.
        /// </summary>
        /// <param name="item">An item.</param>
        /// <param name="priority">The priority of the item. Defaults to 0.</param>
        public void Add(T item, int priority = 0)
        {
            this.Enqueue(item, priority);
        }

        /// <summary>
        /// The number of items in the priority queue.
        /// </summary>
        public int Count
        {
            get
            {
                return this.Items.Count;
            }
        }

        /// <summary>
        /// Adds an item to the queue.
        /// </summary>
        /// <param name="item">An item.</param>
        /// <param name="priority">The priority of the item. Defaults to 0.</param>
        public void Enqueue(T item, int priority = 0)
        {
            this.Items.Add(new PriorityQueueItem<T>(item, priority));
        }

        /// <summary>
        /// Gets an enumerator sorted by the priority.
        /// </summary>
        /// <returns>The enumerator.</returns>
        public IEnumerable<T> GetPriorityEnumerator()
        {
            return this.Items.ToArray().OrderByDescending(i => i.Priority).Select(i => i.Item);
        }

        /// <summary>
        /// Returns the next item in the queue, and then removes it from queue.
        /// </summary>
        /// <returns>The next item in the queue.</returns>
        public T Dequeue()
        {
            return this.Dequeue(true);
        }

        /// <summary>
        /// Returns the next item in the queue.
        /// </summary>
        /// <param name="remove">Whether to remove the item from the queue.</param>
        /// <returns>The next item in the queue.</returns>
        private T Dequeue(bool remove)
        {
            PriorityQueueItem<T>[] array = this.Items.ToArray();
            if (array.Length == 0) return default(T);

            int maxPriority = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[maxPriority].Priority < array[i].Priority)
                {
                    maxPriority = i;
                }
            }

            PriorityQueueItem<T> nextItem = array[maxPriority];
            if (remove) this.Items.RemoveAt(maxPriority);

            return nextItem.Item;
        }

        /// <summary>
        /// Returns the next item in the queue, without removing it.
        /// </summary>
        /// <returns>The next item in the queue.</returns>
        public T Peek()
        {
            return this.Dequeue(false);
        }

        /// <summary>
        /// Gets or sets the item at the specified index.
        /// </summary>
        /// <param name="index">The specified index.</param>
        /// <returns>The item.</returns>
        public T this[int index]
        {
            get
            {
                return this.Items[index].Item;
            }
            set
            {
                this.Items[index] = new PriorityQueueItem<T>(value);
            }
        }

        /// <see cref="IEnumerable&lt;T&gt;.GetEnumerator()"/>
        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in this.Items.OrderByDescending(i => i.Priority).Select(i => i.Item))
            {
                yield return item;
            }
        }

        /// <param name="remove">Whether to remove the items that have been returned from the enumerator.</param>
        /// <see cref="IEnumerable&lt;T&gt;.GetEnumerator()"/>
        public IEnumerator<T> GetEnumerator(bool remove)
        {
            PriorityQueueItem<T>[] array = this.Items.OrderByDescending(i => i.Priority).ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                if (remove) this.Items.Remove(array[i]);
                yield return array[i].Item;
            }
        }

        /// <see cref="IEnumerable&lt;T&gt;.GetEnumerator()"/>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            foreach (T item in this.Items.OrderByDescending(i => i.Priority).Select(i => i.Item))
            {
                yield return item;
            }
        }
    }
}