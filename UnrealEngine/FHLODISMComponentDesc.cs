using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C32 RID: 3122
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.HLODISMComponentDesc")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FHLODISMComponentDesc : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009E44 RID: 40516 RVA: 0x000E0F0A File Offset: 0x000DF10A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FHLODISMComponentDesc._ScriptStructPtr != 0) ? FHLODISMComponentDesc._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.HLODISMComponentDesc", ref FHLODISMComponentDesc._ScriptStructPtr);
		}

		// Token: 0x170025D0 RID: 9680
		// (get) Token: 0x06009E45 RID: 40517 RVA: 0x000E0F2E File Offset: 0x000DF12E
		// (set) Token: 0x06009E46 RID: 40518 RVA: 0x000E0F42 File Offset: 0x000DF142
		public unsafe UStaticMesh StaticMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + FHLODISMComponentDesc.__PropertyOffset_StaticMesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FHLODISMComponentDesc.__PropertyOffset_StaticMesh, value);
			}
		}

		// Token: 0x170025D1 RID: 9681
		// (get) Token: 0x06009E47 RID: 40519 RVA: 0x000E0F57 File Offset: 0x000DF157
		// (set) Token: 0x06009E48 RID: 40520 RVA: 0x000E0F6B File Offset: 0x000DF16B
		public unsafe UMaterialInterface Material
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + FHLODISMComponentDesc.__PropertyOffset_Material);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FHLODISMComponentDesc.__PropertyOffset_Material, value);
			}
		}

		// Token: 0x170025D2 RID: 9682
		// (get) Token: 0x06009E49 RID: 40521 RVA: 0x000E0F80 File Offset: 0x000DF180
		// (set) Token: 0x06009E4A RID: 40522 RVA: 0x000E0FC3 File Offset: 0x000DF1C3
		[Nullable(1)]
		public TArray<FTransform> Instances
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FTransform> result;
				if ((result = this._Instances) == null)
				{
					result = (this._Instances = new TArray<FTransform>(base.NativePtr + (IntPtr)FHLODISMComponentDesc.__PropertyOffset_Instances, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Instances.CopyAssign(value);
			}
		}

		// Token: 0x06009E4B RID: 40523 RVA: 0x000E0FD1 File Offset: 0x000DF1D1
		public FHLODISMComponentDesc()
		{
		}

		// Token: 0x06009E4C RID: 40524 RVA: 0x000E0FD9 File Offset: 0x000DF1D9
		[NullableContext(1)]
		public FHLODISMComponentDesc(UStaticMesh StaticMesh, UMaterialInterface Material, TArray<FTransform> Instances)
		{
			this.StaticMesh = StaticMesh;
			this.Material = Material;
			this.Instances = Instances;
		}

		// Token: 0x06009E4D RID: 40525 RVA: 0x000E0FF6 File Offset: 0x000DF1F6
		protected override IntPtr GetUStructPtr()
		{
			return FHLODISMComponentDesc.StaticStruct();
		}

		// Token: 0x06009E4E RID: 40526 RVA: 0x000E1002 File Offset: 0x000DF202
		public FHLODISMComponentDesc(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009E4F RID: 40527 RVA: 0x000E100C File Offset: 0x000DF20C
		public FHLODISMComponentDesc(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009E50 RID: 40528 RVA: 0x000E1017 File Offset: 0x000DF217
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FHLODISMComponentDesc(Pointer, false, true);
		}

		// Token: 0x06009E51 RID: 40529 RVA: 0x000E1021 File Offset: 0x000DF221
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FHLODISMComponentDesc(Pointer, MemoryOwner);
		}

		// Token: 0x0400573E RID: 22334
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.HLODISMComponentDesc";

		// Token: 0x0400573F RID: 22335
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005740 RID: 22336
		internal static int __PropertyOffset_StaticMesh;

		// Token: 0x04005741 RID: 22337
		internal static int __PropertyOffset_Material;

		// Token: 0x04005742 RID: 22338
		internal static int __PropertyOffset_Instances;

		// Token: 0x04005743 RID: 22339
		private TArray<FTransform> _Instances;
	}
}
