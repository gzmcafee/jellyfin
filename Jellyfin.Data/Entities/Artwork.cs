//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
//
//     Produced by Entity Framework Visual Editor
//     https://github.com/msawczyn/EFDesigner
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Jellyfin.Data.Entities
{
   public partial class Artwork
   {
      partial void Init();

      /// <summary>
      /// Default constructor. Protected due to required properties, but present because EF needs it.
      /// </summary>
      protected Artwork()
      {
         Init();
      }

      /// <summary>
      /// Replaces default constructor, since it's protected. Caller assumes responsibility for setting all required values before saving.
      /// </summary>
      public static Artwork CreateArtworkUnsafe()
      {
         return new Artwork();
      }

      /// <summary>
      /// Public constructor with required data
      /// </summary>
      /// <param name="path"></param>
      /// <param name="kind"></param>
      /// <param name="_metadata0"></param>
      /// <param name="_personrole1"></param>
      public Artwork(string path, global::Jellyfin.Data.Enums.ArtKind kind, global::Jellyfin.Data.Entities.Metadata _metadata0, global::Jellyfin.Data.Entities.PersonRole _personrole1)
      {
         if (string.IsNullOrEmpty(path)) throw new ArgumentNullException(nameof(path));
         this.Path = path;

         this.Kind = kind;

         if (_metadata0 == null) throw new ArgumentNullException(nameof(_metadata0));
         _metadata0.Artwork.Add(this);

         if (_personrole1 == null) throw new ArgumentNullException(nameof(_personrole1));
         _personrole1.Artwork = this;


         Init();
      }

      /// <summary>
      /// Static create function (for use in LINQ queries, etc.)
      /// </summary>
      /// <param name="path"></param>
      /// <param name="kind"></param>
      /// <param name="_metadata0"></param>
      /// <param name="_personrole1"></param>
      public static Artwork Create(string path, global::Jellyfin.Data.Enums.ArtKind kind, global::Jellyfin.Data.Entities.Metadata _metadata0, global::Jellyfin.Data.Entities.PersonRole _personrole1)
      {
         return new Artwork(path, kind, _metadata0, _personrole1);
      }

      /*************************************************************************
       * Properties
       *************************************************************************/

      /// <summary>
      /// Backing field for Id
      /// </summary>
      internal int _Id;
      /// <summary>
      /// When provided in a partial class, allows value of Id to be changed before setting.
      /// </summary>
      partial void SetId(int oldValue, ref int newValue);
      /// <summary>
      /// When provided in a partial class, allows value of Id to be changed before returning.
      /// </summary>
      partial void GetId(ref int result);

      /// <summary>
      /// Identity, Indexed, Required
      /// </summary>
      [Key]
      [Required]
      public int Id
      {
         get
         {
            int value = _Id;
            GetId(ref value);
            return (_Id = value);
         }
         protected set
         {
            int oldValue = _Id;
            SetId(oldValue, ref value);
            if (oldValue != value)
            {
               _Id = value;
            }
         }
      }

      /// <summary>
      /// Backing field for Path
      /// </summary>
      protected string _Path;
      /// <summary>
      /// When provided in a partial class, allows value of Path to be changed before setting.
      /// </summary>
      partial void SetPath(string oldValue, ref string newValue);
      /// <summary>
      /// When provided in a partial class, allows value of Path to be changed before returning.
      /// </summary>
      partial void GetPath(ref string result);

      /// <summary>
      /// Required, Max length = 65535
      /// </summary>
      [Required]
      [MaxLength(65535)]
      [StringLength(65535)]
      public string Path
      {
         get
         {
            string value = _Path;
            GetPath(ref value);
            return (_Path = value);
         }
         set
         {
            string oldValue = _Path;
            SetPath(oldValue, ref value);
            if (oldValue != value)
            {
               _Path = value;
            }
         }
      }

      /// <summary>
      /// Backing field for Kind
      /// </summary>
      internal global::Jellyfin.Data.Enums.ArtKind _Kind;
      /// <summary>
      /// When provided in a partial class, allows value of Kind to be changed before setting.
      /// </summary>
      partial void SetKind(global::Jellyfin.Data.Enums.ArtKind oldValue, ref global::Jellyfin.Data.Enums.ArtKind newValue);
      /// <summary>
      /// When provided in a partial class, allows value of Kind to be changed before returning.
      /// </summary>
      partial void GetKind(ref global::Jellyfin.Data.Enums.ArtKind result);

      /// <summary>
      /// Indexed, Required
      /// </summary>
      [Required]
      public global::Jellyfin.Data.Enums.ArtKind Kind
      {
         get
         {
            global::Jellyfin.Data.Enums.ArtKind value = _Kind;
            GetKind(ref value);
            return (_Kind = value);
         }
         set
         {
            global::Jellyfin.Data.Enums.ArtKind oldValue = _Kind;
            SetKind(oldValue, ref value);
            if (oldValue != value)
            {
               _Kind = value;
            }
         }
      }

      /// <summary>
      /// Required
      /// </summary>
      [ConcurrencyCheck]
      [Required]
      public byte[] Timestamp { get; set; }

      /*************************************************************************
       * Navigation properties
       *************************************************************************/

   }
}
