using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using RZEngine.Core.Object;

namespace RZEngine.Core.Utilities
{
    #region QUADTREE

    // public class QuadTree
    // {
    //     private Rectangle _bound;
    //     private int _nodeObjectLimit = 10;
    //     private int _maxTreeDepth = 5;
    //     private int _currentTreeDepth = 0;
    //     private bool _splitted = false;

    //     private List<GameObject> _objects;
    //     private QuadTree _node1;
    //     private QuadTree _node2;
    //     private QuadTree _node3;
    //     private QuadTree _node4;

    //     public QuadTree(int x, int y, int w, int h, int depth = 0)
    //     {
    //         _currentTreeDepth = depth;

    //         _bound = new Rectangle(x, y, w, h);
    //         _objects = new List<GameObject>();
    //     }

    //     public bool Insert(GameObject obj)
    //     {
    //         if (!_bound.Contains((int)MathF.Round(obj.Position.X), (int)MathF.Round(obj.Position.Y)))
    //         {
    //             return false;
    //         }

    //         if (_objects.Count < _nodeObjectLimit)
    //         {
    //             _objects.Add(obj);
    //             return true;
    //         }
    //         else
    //         {
    //             if (_currentTreeDepth > _maxTreeDepth)
    //             {
    //                 return false;
    //             }
    //             else
    //             {
    //                 if (!_splitted)
    //                 {
    //                     SplitNode();
    //                 }

    //                 if (_node1.Insert(obj)) { return true; }
    //                 else if (_node2.Insert(obj)) { return true; }
    //                 else if (_node3.Insert(obj)) { return true; }
    //                 else if (_node4.Insert(obj)) { return true; }
    //                 else { return false; }
    //             }
    //         }
    //     }

    //     public bool IsInbound(GameObject obj)
    //     {
    //         Vector2 pos = obj.Position;
    //         return pos.X >= _bound.X - _bound.Width && pos.X <= _bound.X + _bound.Width && pos.Y >= _bound.Y - _bound.Height && pos.Y <= _bound.Y + _bound.Height;
    //     }

    //     public void SplitNode()
    //     {
    //         _node1 = new QuadTree(_bound.X, _bound.Y, _bound.Width / 2, _bound.Height / 2, _currentTreeDepth + 1);
    //         _node2 = new QuadTree(_bound.X + _bound.Width / 2, _bound.Y, _bound.Width / 2, _bound.Height / 2, _currentTreeDepth + 1);
    //         _node3 = new QuadTree(_bound.X, _bound.Y + _bound.Height / 2, _bound.Width / 2, _bound.Height / 2, _currentTreeDepth + 1);
    //         _node4 = new QuadTree(_bound.X + _bound.Width / 2, _bound.Y + _bound.Height / 2, _bound.Width / 2, _bound.Height / 2, _currentTreeDepth + 1);

    //         _splitted = true;
    //     }

    //     public List<GameObject> Query(Rectangle range)
    //     {
    //         List<GameObject> objectsFound = new List<GameObject>();
    //         if (!_bound.Intersects(range))
    //         {
    //             return objectsFound;
    //         }
    //         else
    //         {
    //             foreach (GameObject obj in _objects)
    //             {
    //                 if (range.Contains((int)MathF.Round(obj.Position.X), (int)MathF.Round(obj.Position.Y)))
    //                 {
    //                     objectsFound.Add(obj);
    //                 }
    //             }

    //             if (_splitted)
    //             {
    //                 objectsFound.AddRange(_node1.Query(range));
    //                 objectsFound.AddRange(_node2.Query(range));
    //                 objectsFound.AddRange(_node3.Query(range));
    //                 objectsFound.AddRange(_node4.Query(range));
    //             }

    //             return objectsFound;
    //         }
    //     }

    //     public List<GameObject> Query(Vector2 position, float radius)
    //     {
    //         List<GameObject> objectsFound = new List<GameObject>();
    //         if (!CollisionHelper.RectCircleOverlap(position, radius, _bound))
    //         {
    //             return objectsFound;
    //         }
    //         else
    //         {
    //             foreach (GameObject obj in _objects)
    //             {
    //                 float distance = Vector2.Distance(position, obj.Position);
    //                 if (distance <= radius)
    //                 {
    //                     objectsFound.Add(obj);
    //                 }
    //             }

    //             if (_splitted)
    //             {
    //                 objectsFound.AddRange(_node1.Query(position, radius));
    //                 objectsFound.AddRange(_node2.Query(position, radius));
    //                 objectsFound.AddRange(_node3.Query(position, radius));
    //                 objectsFound.AddRange(_node4.Query(position, radius));
    //             }

    //             return objectsFound;
    //         }
    //     }
    // }

    #endregion
}
