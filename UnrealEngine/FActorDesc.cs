using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007BB RID: 1979
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ActorDesc")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 168)]
	public class FActorDesc : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060069D6 RID: 27094 RVA: 0x00097F38 File Offset: 0x00096138
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FActorDesc._ScriptStructPtr != 0) ? FActorDesc._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ActorDesc", ref FActorDesc._ScriptStructPtr);
		}

		// Token: 0x17001905 RID: 6405
		// (get) Token: 0x060069D7 RID: 27095 RVA: 0x00097F5C File Offset: 0x0009615C
		// (set) Token: 0x060069D8 RID: 27096 RVA: 0x00097F70 File Offset: 0x00096170
		public unsafe FGuid Guid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FActorDesc.__PropertyOffset_Guid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FActorDesc.__PropertyOffset_Guid) = value;
			}
		}

		// Token: 0x17001906 RID: 6406
		// (get) Token: 0x060069D9 RID: 27097 RVA: 0x00097F85 File Offset: 0x00096185
		// (set) Token: 0x060069DA RID: 27098 RVA: 0x00097F99 File Offset: 0x00096199
		public unsafe UClassStackOnlyPtr NativeClass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FActorDesc.__PropertyOffset_NativeClass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FActorDesc.__PropertyOffset_NativeClass) = value;
			}
		}

		// Token: 0x17001907 RID: 6407
		// (get) Token: 0x060069DB RID: 27099 RVA: 0x00097FB0 File Offset: 0x000961B0
		// (set) Token: 0x060069DC RID: 27100 RVA: 0x00097FF3 File Offset: 0x000961F3
		public FSoftObjectPath Class
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._Class) == null)
				{
					result = (this._Class = new FSoftObjectPath(base.NativePtr + (IntPtr)FActorDesc.__PropertyOffset_Class, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)FActorDesc.__PropertyOffset_Class, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001908 RID: 6408
		// (get) Token: 0x060069DD RID: 27101 RVA: 0x00098014 File Offset: 0x00096214
		// (set) Token: 0x060069DE RID: 27102 RVA: 0x00098028 File Offset: 0x00096228
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FActorDesc.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FActorDesc.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x17001909 RID: 6409
		// (get) Token: 0x060069DF RID: 27103 RVA: 0x0009803D File Offset: 0x0009623D
		// (set) Token: 0x060069E0 RID: 27104 RVA: 0x00098051 File Offset: 0x00096251
		public unsafe FName Label
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FActorDesc.__PropertyOffset_Label);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FActorDesc.__PropertyOffset_Label) = value;
			}
		}

		// Token: 0x1700190A RID: 6410
		// (get) Token: 0x060069E1 RID: 27105 RVA: 0x00098066 File Offset: 0x00096266
		// (set) Token: 0x060069E2 RID: 27106 RVA: 0x0009807A File Offset: 0x0009627A
		public unsafe FBox Bounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FActorDesc.__PropertyOffset_Bounds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FActorDesc.__PropertyOffset_Bounds) = value;
			}
		}

		// Token: 0x1700190B RID: 6411
		// (get) Token: 0x060069E3 RID: 27107 RVA: 0x0009808F File Offset: 0x0009628F
		// (set) Token: 0x060069E4 RID: 27108 RVA: 0x000980A3 File Offset: 0x000962A3
		public unsafe FName RuntimeGrid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FActorDesc.__PropertyOffset_RuntimeGrid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FActorDesc.__PropertyOffset_RuntimeGrid) = value;
			}
		}

		// Token: 0x1700190C RID: 6412
		// (get) Token: 0x060069E5 RID: 27109 RVA: 0x000980B8 File Offset: 0x000962B8
		// (set) Token: 0x060069E6 RID: 27110 RVA: 0x000980C8 File Offset: 0x000962C8
		public unsafe bool bIsSpatiallyLoaded
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FActorDesc.__PropertyOffset_bIsSpatiallyLoaded) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FActorDesc.__PropertyOffset_bIsSpatiallyLoaded) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700190D RID: 6413
		// (get) Token: 0x060069E7 RID: 27111 RVA: 0x000980D9 File Offset: 0x000962D9
		// (set) Token: 0x060069E8 RID: 27112 RVA: 0x000980E9 File Offset: 0x000962E9
		public unsafe bool bActorIsEditorOnly
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FActorDesc.__PropertyOffset_bActorIsEditorOnly) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FActorDesc.__PropertyOffset_bActorIsEditorOnly) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700190E RID: 6414
		// (get) Token: 0x060069E9 RID: 27113 RVA: 0x000980FA File Offset: 0x000962FA
		// (set) Token: 0x060069EA RID: 27114 RVA: 0x0009810E File Offset: 0x0009630E
		public unsafe FName ActorPackage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FActorDesc.__PropertyOffset_ActorPackage);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FActorDesc.__PropertyOffset_ActorPackage) = value;
			}
		}

		// Token: 0x1700190F RID: 6415
		// (get) Token: 0x060069EB RID: 27115 RVA: 0x00098123 File Offset: 0x00096323
		// (set) Token: 0x060069EC RID: 27116 RVA: 0x00098137 File Offset: 0x00096337
		public unsafe FName ActorPath
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FActorDesc.__PropertyOffset_ActorPath);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FActorDesc.__PropertyOffset_ActorPath) = value;
			}
		}

		// Token: 0x17001910 RID: 6416
		// (get) Token: 0x060069ED RID: 27117 RVA: 0x0009814C File Offset: 0x0009634C
		// (set) Token: 0x060069EE RID: 27118 RVA: 0x0009818F File Offset: 0x0009638F
		public TArray<FSoftObjectPath> DataLayerAssets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSoftObjectPath> result;
				if ((result = this._DataLayerAssets) == null)
				{
					result = (this._DataLayerAssets = new TArray<FSoftObjectPath>(base.NativePtr + (IntPtr)FActorDesc.__PropertyOffset_DataLayerAssets, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DataLayerAssets.CopyAssign(value);
			}
		}

		// Token: 0x060069EF RID: 27119 RVA: 0x0009819D File Offset: 0x0009639D
		public FActorDesc()
		{
		}

		// Token: 0x060069F0 RID: 27120 RVA: 0x000981A8 File Offset: 0x000963A8
		public FActorDesc(FGuid Guid, UClassStackOnlyPtr NativeClass, FSoftObjectPath Class, FName Name, FName Label, FBox Bounds, FName RuntimeGrid, bool bIsSpatiallyLoaded, bool bActorIsEditorOnly, FName ActorPackage, FName ActorPath, TArray<FSoftObjectPath> DataLayerAssets)
		{
			this.Guid = Guid;
			this.NativeClass = NativeClass;
			this.Class = Class;
			this.Name = Name;
			this.Label = Label;
			this.Bounds = Bounds;
			this.RuntimeGrid = RuntimeGrid;
			this.bIsSpatiallyLoaded = bIsSpatiallyLoaded;
			this.bActorIsEditorOnly = bActorIsEditorOnly;
			this.ActorPackage = ActorPackage;
			this.ActorPath = ActorPath;
			this.DataLayerAssets = DataLayerAssets;
		}

		// Token: 0x060069F1 RID: 27121 RVA: 0x00098218 File Offset: 0x00096418
		protected override IntPtr GetUStructPtr()
		{
			return FActorDesc.StaticStruct();
		}

		// Token: 0x060069F2 RID: 27122 RVA: 0x00098224 File Offset: 0x00096424
		[NullableContext(2)]
		public FActorDesc(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060069F3 RID: 27123 RVA: 0x0009822E File Offset: 0x0009642E
		public FActorDesc(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060069F4 RID: 27124 RVA: 0x00098239 File Offset: 0x00096439
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FActorDesc(Pointer, false, true);
		}

		// Token: 0x060069F5 RID: 27125 RVA: 0x00098243 File Offset: 0x00096443
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FActorDesc(Pointer, MemoryOwner);
		}

		// Token: 0x04003303 RID: 13059
		public const string __ObjectPath = "/Script/Engine.ActorDesc";

		// Token: 0x04003304 RID: 13060
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003305 RID: 13061
		internal static int __PropertyOffset_Guid;

		// Token: 0x04003306 RID: 13062
		internal static int __PropertyOffset_NativeClass;

		// Token: 0x04003307 RID: 13063
		internal static int __PropertyOffset_Class;

		// Token: 0x04003308 RID: 13064
		[Nullable(2)]
		private FSoftObjectPath _Class;

		// Token: 0x04003309 RID: 13065
		internal static int __PropertyOffset_Name;

		// Token: 0x0400330A RID: 13066
		internal static int __PropertyOffset_Label;

		// Token: 0x0400330B RID: 13067
		internal static int __PropertyOffset_Bounds;

		// Token: 0x0400330C RID: 13068
		internal static int __PropertyOffset_RuntimeGrid;

		// Token: 0x0400330D RID: 13069
		internal static int __PropertyOffset_bIsSpatiallyLoaded;

		// Token: 0x0400330E RID: 13070
		internal static int __PropertyOffset_bActorIsEditorOnly;

		// Token: 0x0400330F RID: 13071
		internal static int __PropertyOffset_ActorPackage;

		// Token: 0x04003310 RID: 13072
		internal static int __PropertyOffset_ActorPath;

		// Token: 0x04003311 RID: 13073
		internal static int __PropertyOffset_DataLayerAssets;

		// Token: 0x04003312 RID: 13074
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSoftObjectPath> _DataLayerAssets;
	}
}
