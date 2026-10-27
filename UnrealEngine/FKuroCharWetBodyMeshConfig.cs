using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001AC5 RID: 6853
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroCharWetBodyMeshConfig")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FKuroCharWetBodyMeshConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601974E RID: 104270 RVA: 0x0025A0F9 File Offset: 0x002582F9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCharWetBodyMeshConfig._ScriptStructPtr != 0) ? FKuroCharWetBodyMeshConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroCharWetBodyMeshConfig", ref FKuroCharWetBodyMeshConfig._ScriptStructPtr);
		}

		// Token: 0x17006580 RID: 25984
		// (get) Token: 0x0601974F RID: 104271 RVA: 0x0025A11D File Offset: 0x0025831D
		// (set) Token: 0x06019750 RID: 104272 RVA: 0x0025A131 File Offset: 0x00258331
		public unsafe string SkeletalMeshName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroCharWetBodyMeshConfig.__PropertyOffset_SkeletalMeshName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroCharWetBodyMeshConfig.__PropertyOffset_SkeletalMeshName)), value);
			}
		}

		// Token: 0x17006581 RID: 25985
		// (get) Token: 0x06019751 RID: 104273 RVA: 0x0025A148 File Offset: 0x00258348
		// (set) Token: 0x06019752 RID: 104274 RVA: 0x0025A18B File Offset: 0x0025838B
		public TArray<FKuroCharWetMatCustomParamConfigs> CharWetMatCustomParamConfigs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroCharWetMatCustomParamConfigs> result;
				if ((result = this._CharWetMatCustomParamConfigs) == null)
				{
					result = (this._CharWetMatCustomParamConfigs = new TArray<FKuroCharWetMatCustomParamConfigs>(base.NativePtr + (IntPtr)FKuroCharWetBodyMeshConfig.__PropertyOffset_CharWetMatCustomParamConfigs, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CharWetMatCustomParamConfigs.CopyAssign(value);
			}
		}

		// Token: 0x06019753 RID: 104275 RVA: 0x0025A199 File Offset: 0x00258399
		public FKuroCharWetBodyMeshConfig()
		{
		}

		// Token: 0x06019754 RID: 104276 RVA: 0x0025A1A1 File Offset: 0x002583A1
		public FKuroCharWetBodyMeshConfig(string SkeletalMeshName, TArray<FKuroCharWetMatCustomParamConfigs> CharWetMatCustomParamConfigs)
		{
			this.SkeletalMeshName = SkeletalMeshName;
			this.CharWetMatCustomParamConfigs = CharWetMatCustomParamConfigs;
		}

		// Token: 0x06019755 RID: 104277 RVA: 0x0025A1B7 File Offset: 0x002583B7
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCharWetBodyMeshConfig.StaticStruct();
		}

		// Token: 0x06019756 RID: 104278 RVA: 0x0025A1C3 File Offset: 0x002583C3
		[NullableContext(2)]
		public FKuroCharWetBodyMeshConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06019757 RID: 104279 RVA: 0x0025A1CD File Offset: 0x002583CD
		public FKuroCharWetBodyMeshConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06019758 RID: 104280 RVA: 0x0025A1D8 File Offset: 0x002583D8
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCharWetBodyMeshConfig(Pointer, false, true);
		}

		// Token: 0x06019759 RID: 104281 RVA: 0x0025A1E2 File Offset: 0x002583E2
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCharWetBodyMeshConfig(Pointer, MemoryOwner);
		}

		// Token: 0x0400DDC3 RID: 56771
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroCharWetBodyMeshConfig";

		// Token: 0x0400DDC4 RID: 56772
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400DDC5 RID: 56773
		internal static int __PropertyOffset_SkeletalMeshName;

		// Token: 0x0400DDC6 RID: 56774
		internal static int __PropertyOffset_CharWetMatCustomParamConfigs;

		// Token: 0x0400DDC7 RID: 56775
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroCharWetMatCustomParamConfigs> _CharWetMatCustomParamConfigs;
	}
}
