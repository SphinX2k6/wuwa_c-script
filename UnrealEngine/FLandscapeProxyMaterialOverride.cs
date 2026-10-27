using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F87 RID: 8071
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Landscape.LandscapeProxyMaterialOverride")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FLandscapeProxyMaterialOverride : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601EA63 RID: 125539 RVA: 0x002D8FB1 File Offset: 0x002D71B1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLandscapeProxyMaterialOverride._ScriptStructPtr != 0) ? FLandscapeProxyMaterialOverride._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Landscape.LandscapeProxyMaterialOverride", ref FLandscapeProxyMaterialOverride._ScriptStructPtr);
		}

		// Token: 0x17007A0F RID: 31247
		// (get) Token: 0x0601EA64 RID: 125540 RVA: 0x002D8FD8 File Offset: 0x002D71D8
		// (set) Token: 0x0601EA65 RID: 125541 RVA: 0x002D901B File Offset: 0x002D721B
		public FPerPlatformInt LODIndex
		{
			get
			{
				base.FastCheckIsValid();
				FPerPlatformInt result;
				if ((result = this._LODIndex) == null)
				{
					result = (this._LODIndex = new FPerPlatformInt(base.NativePtr + (IntPtr)FLandscapeProxyMaterialOverride.__PropertyOffset_LODIndex, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPerPlatformInt.StaticStruct(), base.NativePtr + (IntPtr)FLandscapeProxyMaterialOverride.__PropertyOffset_LODIndex, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007A10 RID: 31248
		// (get) Token: 0x0601EA66 RID: 125542 RVA: 0x002D903C File Offset: 0x002D723C
		// (set) Token: 0x0601EA67 RID: 125543 RVA: 0x002D9050 File Offset: 0x002D7250
		[Nullable(2)]
		public unsafe UMaterialInterface Material
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + FLandscapeProxyMaterialOverride.__PropertyOffset_Material);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FLandscapeProxyMaterialOverride.__PropertyOffset_Material, value);
			}
		}

		// Token: 0x0601EA68 RID: 125544 RVA: 0x002D9065 File Offset: 0x002D7265
		public FLandscapeProxyMaterialOverride()
		{
		}

		// Token: 0x0601EA69 RID: 125545 RVA: 0x002D906D File Offset: 0x002D726D
		public FLandscapeProxyMaterialOverride(FPerPlatformInt LODIndex, UMaterialInterface Material)
		{
			this.LODIndex = LODIndex;
			this.Material = Material;
		}

		// Token: 0x0601EA6A RID: 125546 RVA: 0x002D9083 File Offset: 0x002D7283
		protected override IntPtr GetUStructPtr()
		{
			return FLandscapeProxyMaterialOverride.StaticStruct();
		}

		// Token: 0x0601EA6B RID: 125547 RVA: 0x002D908F File Offset: 0x002D728F
		[NullableContext(2)]
		public FLandscapeProxyMaterialOverride(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601EA6C RID: 125548 RVA: 0x002D9099 File Offset: 0x002D7299
		public FLandscapeProxyMaterialOverride(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601EA6D RID: 125549 RVA: 0x002D90A4 File Offset: 0x002D72A4
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLandscapeProxyMaterialOverride(Pointer, false, true);
		}

		// Token: 0x0601EA6E RID: 125550 RVA: 0x002D90AE File Offset: 0x002D72AE
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLandscapeProxyMaterialOverride(Pointer, MemoryOwner);
		}

		// Token: 0x04010919 RID: 67865
		public const string __ObjectPath = "/Script/Landscape.LandscapeProxyMaterialOverride";

		// Token: 0x0401091A RID: 67866
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401091B RID: 67867
		internal static int __PropertyOffset_LODIndex;

		// Token: 0x0401091C RID: 67868
		[Nullable(2)]
		private FPerPlatformInt _LODIndex;

		// Token: 0x0401091D RID: 67869
		internal static int __PropertyOffset_Material;
	}
}
