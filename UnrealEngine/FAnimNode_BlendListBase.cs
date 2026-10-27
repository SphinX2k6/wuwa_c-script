using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002D2 RID: 722
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimNode_BlendListBase")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 168)]
	public class FAnimNode_BlendListBase : FAnimNode_Base, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002866 RID: 10342 RVA: 0x0003CDA2 File Offset: 0x0003AFA2
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_BlendListBase._ScriptStructPtr != 0) ? FAnimNode_BlendListBase._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AnimNode_BlendListBase", ref FAnimNode_BlendListBase._ScriptStructPtr);
		}

		// Token: 0x170009BD RID: 2493
		// (get) Token: 0x06002867 RID: 10343 RVA: 0x0003CDC8 File Offset: 0x0003AFC8
		// (set) Token: 0x06002868 RID: 10344 RVA: 0x0003CE0B File Offset: 0x0003B00B
		public TArray<FPoseLink> BlendPose
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FPoseLink> result;
				if ((result = this._BlendPose) == null)
				{
					result = (this._BlendPose = new TArray<FPoseLink>(base.NativePtr + (IntPtr)FAnimNode_BlendListBase.__PropertyOffset_BlendPose, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BlendPose.CopyAssign(value);
			}
		}

		// Token: 0x170009BE RID: 2494
		// (get) Token: 0x06002869 RID: 10345 RVA: 0x0003CE1C File Offset: 0x0003B01C
		// (set) Token: 0x0600286A RID: 10346 RVA: 0x0003CE5F File Offset: 0x0003B05F
		public TArray<float> BlendTime
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._BlendTime) == null)
				{
					result = (this._BlendTime = new TArray<float>(base.NativePtr + (IntPtr)FAnimNode_BlendListBase.__PropertyOffset_BlendTime, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BlendTime.CopyAssign(value);
			}
		}

		// Token: 0x170009BF RID: 2495
		// (get) Token: 0x0600286B RID: 10347 RVA: 0x0003CE6D File Offset: 0x0003B06D
		// (set) Token: 0x0600286C RID: 10348 RVA: 0x0003CE7D File Offset: 0x0003B07D
		public unsafe EBlendListTransitionType TransitionType
		{
			get
			{
				return (EBlendListTransitionType)(*(base.NativePtr + (IntPtr)FAnimNode_BlendListBase.__PropertyOffset_TransitionType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_BlendListBase.__PropertyOffset_TransitionType) = (byte)value;
			}
		}

		// Token: 0x170009C0 RID: 2496
		// (get) Token: 0x0600286D RID: 10349 RVA: 0x0003CE8E File Offset: 0x0003B08E
		// (set) Token: 0x0600286E RID: 10350 RVA: 0x0003CE9E File Offset: 0x0003B09E
		public unsafe EAlphaBlendOption BlendType
		{
			get
			{
				return (EAlphaBlendOption)(*(base.NativePtr + (IntPtr)FAnimNode_BlendListBase.__PropertyOffset_BlendType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_BlendListBase.__PropertyOffset_BlendType) = (byte)value;
			}
		}

		// Token: 0x170009C1 RID: 2497
		// (get) Token: 0x0600286F RID: 10351 RVA: 0x0003CEAF File Offset: 0x0003B0AF
		// (set) Token: 0x06002870 RID: 10352 RVA: 0x0003CEBF File Offset: 0x0003B0BF
		public unsafe bool bResetChildOnActivation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_BlendListBase.__PropertyOffset_bResetChildOnActivation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_BlendListBase.__PropertyOffset_bResetChildOnActivation) = (value ? 1 : 0);
			}
		}

		// Token: 0x170009C2 RID: 2498
		// (get) Token: 0x06002871 RID: 10353 RVA: 0x0003CED0 File Offset: 0x0003B0D0
		// (set) Token: 0x06002872 RID: 10354 RVA: 0x0003CEE4 File Offset: 0x0003B0E4
		[Nullable(2)]
		public unsafe UCurveFloat CustomBlendCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNode_BlendListBase.__PropertyOffset_CustomBlendCurve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNode_BlendListBase.__PropertyOffset_CustomBlendCurve, value);
			}
		}

		// Token: 0x170009C3 RID: 2499
		// (get) Token: 0x06002873 RID: 10355 RVA: 0x0003CEF9 File Offset: 0x0003B0F9
		// (set) Token: 0x06002874 RID: 10356 RVA: 0x0003CF0D File Offset: 0x0003B10D
		[Nullable(2)]
		public unsafe UBlendProfile BlendProfile
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBlendProfile>(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNode_BlendListBase.__PropertyOffset_BlendProfile);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNode_BlendListBase.__PropertyOffset_BlendProfile, value);
			}
		}

		// Token: 0x06002875 RID: 10357 RVA: 0x0003CF22 File Offset: 0x0003B122
		public FAnimNode_BlendListBase()
		{
		}

		// Token: 0x06002876 RID: 10358 RVA: 0x0003CF2A File Offset: 0x0003B12A
		public FAnimNode_BlendListBase(TArray<FPoseLink> BlendPose, TArray<float> BlendTime, EBlendListTransitionType TransitionType, EAlphaBlendOption BlendType, bool bResetChildOnActivation, UCurveFloat CustomBlendCurve, UBlendProfile BlendProfile)
		{
			this.BlendPose = BlendPose;
			this.BlendTime = BlendTime;
			this.TransitionType = TransitionType;
			this.BlendType = BlendType;
			this.bResetChildOnActivation = bResetChildOnActivation;
			this.CustomBlendCurve = CustomBlendCurve;
			this.BlendProfile = BlendProfile;
		}

		// Token: 0x06002877 RID: 10359 RVA: 0x0003CF67 File Offset: 0x0003B167
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_BlendListBase.StaticStruct();
		}

		// Token: 0x06002878 RID: 10360 RVA: 0x0003CF73 File Offset: 0x0003B173
		[NullableContext(2)]
		public FAnimNode_BlendListBase(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002879 RID: 10361 RVA: 0x0003CF7D File Offset: 0x0003B17D
		public FAnimNode_BlendListBase(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600287A RID: 10362 RVA: 0x0003CF88 File Offset: 0x0003B188
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_BlendListBase(Pointer, false, true);
		}

		// Token: 0x0600287B RID: 10363 RVA: 0x0003CF92 File Offset: 0x0003B192
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_BlendListBase(Pointer, MemoryOwner);
		}

		// Token: 0x04001017 RID: 4119
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.AnimNode_BlendListBase";

		// Token: 0x04001018 RID: 4120
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001019 RID: 4121
		internal static int __PropertyOffset_BlendPose;

		// Token: 0x0400101A RID: 4122
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPoseLink> _BlendPose;

		// Token: 0x0400101B RID: 4123
		internal static int __PropertyOffset_BlendTime;

		// Token: 0x0400101C RID: 4124
		[Nullable(2)]
		private TArray<float> _BlendTime;

		// Token: 0x0400101D RID: 4125
		internal static int __PropertyOffset_TransitionType;

		// Token: 0x0400101E RID: 4126
		internal static int __PropertyOffset_BlendType;

		// Token: 0x0400101F RID: 4127
		internal static int __PropertyOffset_bResetChildOnActivation;

		// Token: 0x04001020 RID: 4128
		internal static int __PropertyOffset_CustomBlendCurve;

		// Token: 0x04001021 RID: 4129
		internal static int __PropertyOffset_BlendProfile;
	}
}
