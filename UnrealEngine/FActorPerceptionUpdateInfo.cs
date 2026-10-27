using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000DF RID: 223
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.ActorPerceptionUpdateInfo")]
	[UnrealStructLayout(80, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FActorPerceptionUpdateInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060011BE RID: 4542 RVA: 0x0001A862 File Offset: 0x00018A62
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FActorPerceptionUpdateInfo._ScriptStructPtr != 0) ? FActorPerceptionUpdateInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AIModule.ActorPerceptionUpdateInfo", ref FActorPerceptionUpdateInfo._ScriptStructPtr);
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x060011BF RID: 4543 RVA: 0x0001A886 File Offset: 0x00018A86
		// (set) Token: 0x060011C0 RID: 4544 RVA: 0x0001A896 File Offset: 0x00018A96
		public unsafe int TargetId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FActorPerceptionUpdateInfo.__PropertyOffset_TargetId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FActorPerceptionUpdateInfo.__PropertyOffset_TargetId) = value;
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x060011C1 RID: 4545 RVA: 0x0001A8A7 File Offset: 0x00018AA7
		// (set) Token: 0x060011C2 RID: 4546 RVA: 0x0001A8BB File Offset: 0x00018ABB
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AActor> Target
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FActorPerceptionUpdateInfo.__PropertyOffset_Target);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FActorPerceptionUpdateInfo.__PropertyOffset_Target) = value;
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x060011C3 RID: 4547 RVA: 0x0001A8D0 File Offset: 0x00018AD0
		// (set) Token: 0x060011C4 RID: 4548 RVA: 0x0001A913 File Offset: 0x00018B13
		public FAIStimulus Stimulus
		{
			get
			{
				base.FastCheckIsValid();
				FAIStimulus result;
				if ((result = this._Stimulus) == null)
				{
					result = (this._Stimulus = new FAIStimulus(base.NativePtr + (IntPtr)FActorPerceptionUpdateInfo.__PropertyOffset_Stimulus, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAIStimulus.StaticStruct(), base.NativePtr + (IntPtr)FActorPerceptionUpdateInfo.__PropertyOffset_Stimulus, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060011C5 RID: 4549 RVA: 0x0001A934 File Offset: 0x00018B34
		public FActorPerceptionUpdateInfo()
		{
		}

		// Token: 0x060011C6 RID: 4550 RVA: 0x0001A93C File Offset: 0x00018B3C
		public FActorPerceptionUpdateInfo(int TargetId, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<AActor> Target, FAIStimulus Stimulus)
		{
			this.TargetId = TargetId;
			this.Target = Target;
			this.Stimulus = Stimulus;
		}

		// Token: 0x060011C7 RID: 4551 RVA: 0x0001A959 File Offset: 0x00018B59
		protected override IntPtr GetUStructPtr()
		{
			return FActorPerceptionUpdateInfo.StaticStruct();
		}

		// Token: 0x060011C8 RID: 4552 RVA: 0x0001A965 File Offset: 0x00018B65
		[NullableContext(2)]
		public FActorPerceptionUpdateInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060011C9 RID: 4553 RVA: 0x0001A96F File Offset: 0x00018B6F
		public FActorPerceptionUpdateInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060011CA RID: 4554 RVA: 0x0001A97A File Offset: 0x00018B7A
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FActorPerceptionUpdateInfo(Pointer, false, true);
		}

		// Token: 0x060011CB RID: 4555 RVA: 0x0001A984 File Offset: 0x00018B84
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FActorPerceptionUpdateInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040002EA RID: 746
		public const string __ObjectPath = "/Script/AIModule.ActorPerceptionUpdateInfo";

		// Token: 0x040002EB RID: 747
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040002EC RID: 748
		internal static int __PropertyOffset_TargetId;

		// Token: 0x040002ED RID: 749
		internal static int __PropertyOffset_Target;

		// Token: 0x040002EE RID: 750
		internal static int __PropertyOffset_Stimulus;

		// Token: 0x040002EF RID: 751
		[Nullable(2)]
		private FAIStimulus _Stimulus;
	}
}
