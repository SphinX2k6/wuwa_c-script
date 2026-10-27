using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010F2 RID: 4338
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SkeletalMaterial")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FSkeletalMaterial : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600F8D4 RID: 63700 RVA: 0x0017003E File Offset: 0x0016E23E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSkeletalMaterial._ScriptStructPtr != 0) ? FSkeletalMaterial._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SkeletalMaterial", ref FSkeletalMaterial._ScriptStructPtr);
		}

		// Token: 0x17003C99 RID: 15513
		// (get) Token: 0x0600F8D5 RID: 63701 RVA: 0x00170062 File Offset: 0x0016E262
		// (set) Token: 0x0600F8D6 RID: 63702 RVA: 0x00170076 File Offset: 0x0016E276
		[Nullable(2)]
		public unsafe UMaterialInterface MaterialInterface
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + FSkeletalMaterial.__PropertyOffset_MaterialInterface);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FSkeletalMaterial.__PropertyOffset_MaterialInterface, value);
			}
		}

		// Token: 0x17003C9A RID: 15514
		// (get) Token: 0x0600F8D7 RID: 63703 RVA: 0x0017008B File Offset: 0x0016E28B
		// (set) Token: 0x0600F8D8 RID: 63704 RVA: 0x0017009F File Offset: 0x0016E29F
		public unsafe FName MaterialSlotName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkeletalMaterial.__PropertyOffset_MaterialSlotName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkeletalMaterial.__PropertyOffset_MaterialSlotName) = value;
			}
		}

		// Token: 0x17003C9B RID: 15515
		// (get) Token: 0x0600F8D9 RID: 63705 RVA: 0x001700B4 File Offset: 0x0016E2B4
		// (set) Token: 0x0600F8DA RID: 63706 RVA: 0x001700F7 File Offset: 0x0016E2F7
		public FMeshUVChannelInfo UVChannelData
		{
			get
			{
				base.FastCheckIsValid();
				FMeshUVChannelInfo result;
				if ((result = this._UVChannelData) == null)
				{
					result = (this._UVChannelData = new FMeshUVChannelInfo(base.NativePtr + (IntPtr)FSkeletalMaterial.__PropertyOffset_UVChannelData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMeshUVChannelInfo.StaticStruct(), base.NativePtr + (IntPtr)FSkeletalMaterial.__PropertyOffset_UVChannelData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600F8DB RID: 63707 RVA: 0x00170118 File Offset: 0x0016E318
		public FSkeletalMaterial()
		{
		}

		// Token: 0x0600F8DC RID: 63708 RVA: 0x00170120 File Offset: 0x0016E320
		public FSkeletalMaterial(UMaterialInterface MaterialInterface, FName MaterialSlotName, bool bEnableShadowCasting_DEPRECATED, bool bRecomputeTangent_DEPRECATED, FName ImportedMaterialSlotName, FMeshUVChannelInfo UVChannelData)
		{
			this.MaterialInterface = MaterialInterface;
			this.MaterialSlotName = MaterialSlotName;
			this.UVChannelData = UVChannelData;
		}

		// Token: 0x0600F8DD RID: 63709 RVA: 0x0017013E File Offset: 0x0016E33E
		protected override IntPtr GetUStructPtr()
		{
			return FSkeletalMaterial.StaticStruct();
		}

		// Token: 0x0600F8DE RID: 63710 RVA: 0x0017014A File Offset: 0x0016E34A
		[NullableContext(2)]
		public FSkeletalMaterial(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600F8DF RID: 63711 RVA: 0x00170154 File Offset: 0x0016E354
		public FSkeletalMaterial(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600F8E0 RID: 63712 RVA: 0x0017015F File Offset: 0x0016E35F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSkeletalMaterial(Pointer, false, true);
		}

		// Token: 0x0600F8E1 RID: 63713 RVA: 0x00170169 File Offset: 0x0016E369
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSkeletalMaterial(Pointer, MemoryOwner);
		}

		// Token: 0x0400866D RID: 34413
		public const string __ObjectPath = "/Script/Engine.SkeletalMaterial";

		// Token: 0x0400866E RID: 34414
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400866F RID: 34415
		internal static int __PropertyOffset_MaterialInterface;

		// Token: 0x04008670 RID: 34416
		internal static int __PropertyOffset_MaterialSlotName;

		// Token: 0x04008671 RID: 34417
		internal static int __PropertyOffset_UVChannelData;

		// Token: 0x04008672 RID: 34418
		[Nullable(2)]
		private FMeshUVChannelInfo _UVChannelData;
	}
}
