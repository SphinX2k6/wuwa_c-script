using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200176F RID: 5999
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroComponent.TargetRotationData")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FTargetRotationData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601591E RID: 88350 RVA: 0x001FBC2C File Offset: 0x001F9E2C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTargetRotationData._ScriptStructPtr != 0) ? FTargetRotationData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComponent.TargetRotationData", ref FTargetRotationData._ScriptStructPtr);
		}

		// Token: 0x1700551B RID: 21787
		// (get) Token: 0x0601591F RID: 88351 RVA: 0x001FBC50 File Offset: 0x001F9E50
		// (set) Token: 0x06015920 RID: 88352 RVA: 0x001FBC64 File Offset: 0x001F9E64
		[Nullable(2)]
		public unsafe AActor TargetActor
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + FTargetRotationData.__PropertyOffset_TargetActor);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FTargetRotationData.__PropertyOffset_TargetActor, value);
			}
		}

		// Token: 0x1700551C RID: 21788
		// (get) Token: 0x06015921 RID: 88353 RVA: 0x001FBC7C File Offset: 0x001F9E7C
		// (set) Token: 0x06015922 RID: 88354 RVA: 0x001FBCBF File Offset: 0x001F9EBF
		public TArray<FRotateStepInfo> StepInfos
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRotateStepInfo> result;
				if ((result = this._StepInfos) == null)
				{
					result = (this._StepInfos = new TArray<FRotateStepInfo>(base.NativePtr + (IntPtr)FTargetRotationData.__PropertyOffset_StepInfos, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.StepInfos.CopyAssign(value);
			}
		}

		// Token: 0x06015923 RID: 88355 RVA: 0x001FBCCD File Offset: 0x001F9ECD
		public FTargetRotationData()
		{
		}

		// Token: 0x06015924 RID: 88356 RVA: 0x001FBCD5 File Offset: 0x001F9ED5
		public FTargetRotationData(AActor TargetActor, TArray<FRotateStepInfo> StepInfos)
		{
			this.TargetActor = TargetActor;
			this.StepInfos = StepInfos;
		}

		// Token: 0x06015925 RID: 88357 RVA: 0x001FBCEB File Offset: 0x001F9EEB
		protected override IntPtr GetUStructPtr()
		{
			return FTargetRotationData.StaticStruct();
		}

		// Token: 0x06015926 RID: 88358 RVA: 0x001FBCF7 File Offset: 0x001F9EF7
		[NullableContext(2)]
		public FTargetRotationData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06015927 RID: 88359 RVA: 0x001FBD01 File Offset: 0x001F9F01
		public FTargetRotationData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06015928 RID: 88360 RVA: 0x001FBD0C File Offset: 0x001F9F0C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTargetRotationData(Pointer, false, true);
		}

		// Token: 0x06015929 RID: 88361 RVA: 0x001FBD16 File Offset: 0x001F9F16
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTargetRotationData(Pointer, MemoryOwner);
		}

		// Token: 0x0400BC4E RID: 48206
		public const string __ObjectPath = "/Script/KuroComponent.TargetRotationData";

		// Token: 0x0400BC4F RID: 48207
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400BC50 RID: 48208
		internal static int __PropertyOffset_TargetActor;

		// Token: 0x0400BC51 RID: 48209
		internal static int __PropertyOffset_StepInfos;

		// Token: 0x0400BC52 RID: 48210
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRotateStepInfo> _StepInfos;
	}
}
