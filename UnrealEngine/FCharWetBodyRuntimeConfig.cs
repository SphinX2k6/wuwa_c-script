using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001A58 RID: 6744
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.CharWetBodyRuntimeConfig")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FCharWetBodyRuntimeConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06018F3F RID: 102207 RVA: 0x0024E440 File Offset: 0x0024C640
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCharWetBodyRuntimeConfig._ScriptStructPtr != 0) ? FCharWetBodyRuntimeConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.CharWetBodyRuntimeConfig", ref FCharWetBodyRuntimeConfig._ScriptStructPtr);
		}

		// Token: 0x170062E1 RID: 25313
		// (get) Token: 0x06018F40 RID: 102208 RVA: 0x0024E464 File Offset: 0x0024C664
		// (set) Token: 0x06018F41 RID: 102209 RVA: 0x0024E478 File Offset: 0x0024C678
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<USkeletalMeshComponent> SkeletalMeshComp
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FCharWetBodyRuntimeConfig.__PropertyOffset_SkeletalMeshComp);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FCharWetBodyRuntimeConfig.__PropertyOffset_SkeletalMeshComp) = value;
			}
		}

		// Token: 0x170062E2 RID: 25314
		// (get) Token: 0x06018F42 RID: 102210 RVA: 0x0024E48D File Offset: 0x0024C68D
		// (set) Token: 0x06018F43 RID: 102211 RVA: 0x0024E49D File Offset: 0x0024C69D
		public unsafe int MaterialIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCharWetBodyRuntimeConfig.__PropertyOffset_MaterialIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCharWetBodyRuntimeConfig.__PropertyOffset_MaterialIndex) = value;
			}
		}

		// Token: 0x170062E3 RID: 25315
		// (get) Token: 0x06018F44 RID: 102212 RVA: 0x0024E4AE File Offset: 0x0024C6AE
		// (set) Token: 0x06018F45 RID: 102213 RVA: 0x0024E4C2 File Offset: 0x0024C6C2
		[Nullable(2)]
		public unsafe UMaterialInstanceDynamic MID
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + FCharWetBodyRuntimeConfig.__PropertyOffset_MID);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FCharWetBodyRuntimeConfig.__PropertyOffset_MID, value);
			}
		}

		// Token: 0x06018F46 RID: 102214 RVA: 0x0024E4D7 File Offset: 0x0024C6D7
		public FCharWetBodyRuntimeConfig()
		{
		}

		// Token: 0x06018F47 RID: 102215 RVA: 0x0024E4DF File Offset: 0x0024C6DF
		[NullableContext(1)]
		public FCharWetBodyRuntimeConfig([Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<USkeletalMeshComponent> SkeletalMeshComp, int MaterialIndex, UMaterialInstanceDynamic MID)
		{
			this.SkeletalMeshComp = SkeletalMeshComp;
			this.MaterialIndex = MaterialIndex;
			this.MID = MID;
		}

		// Token: 0x06018F48 RID: 102216 RVA: 0x0024E4FC File Offset: 0x0024C6FC
		protected override IntPtr GetUStructPtr()
		{
			return FCharWetBodyRuntimeConfig.StaticStruct();
		}

		// Token: 0x06018F49 RID: 102217 RVA: 0x0024E508 File Offset: 0x0024C708
		[NullableContext(2)]
		public FCharWetBodyRuntimeConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018F4A RID: 102218 RVA: 0x0024E512 File Offset: 0x0024C712
		public FCharWetBodyRuntimeConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018F4B RID: 102219 RVA: 0x0024E51D File Offset: 0x0024C71D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCharWetBodyRuntimeConfig(Pointer, false, true);
		}

		// Token: 0x06018F4C RID: 102220 RVA: 0x0024E527 File Offset: 0x0024C727
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCharWetBodyRuntimeConfig(Pointer, MemoryOwner);
		}

		// Token: 0x0400D80E RID: 55310
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.CharWetBodyRuntimeConfig";

		// Token: 0x0400D80F RID: 55311
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400D810 RID: 55312
		internal static int __PropertyOffset_SkeletalMeshComp;

		// Token: 0x0400D811 RID: 55313
		internal static int __PropertyOffset_MaterialIndex;

		// Token: 0x0400D812 RID: 55314
		internal static int __PropertyOffset_MID;
	}
}
