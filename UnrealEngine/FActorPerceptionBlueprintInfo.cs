using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000DC RID: 220
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.ActorPerceptionBlueprintInfo")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FActorPerceptionBlueprintInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600119C RID: 4508 RVA: 0x0001A41A File Offset: 0x0001861A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FActorPerceptionBlueprintInfo._ScriptStructPtr != 0) ? FActorPerceptionBlueprintInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AIModule.ActorPerceptionBlueprintInfo", ref FActorPerceptionBlueprintInfo._ScriptStructPtr);
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x0600119D RID: 4509 RVA: 0x0001A43E File Offset: 0x0001863E
		// (set) Token: 0x0600119E RID: 4510 RVA: 0x0001A452 File Offset: 0x00018652
		[Nullable(2)]
		public unsafe AActor Target
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + FActorPerceptionBlueprintInfo.__PropertyOffset_Target);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FActorPerceptionBlueprintInfo.__PropertyOffset_Target, value);
			}
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x0600119F RID: 4511 RVA: 0x0001A468 File Offset: 0x00018668
		// (set) Token: 0x060011A0 RID: 4512 RVA: 0x0001A4AB File Offset: 0x000186AB
		public TArray<FAIStimulus> LastSensedStimuli
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAIStimulus> result;
				if ((result = this._LastSensedStimuli) == null)
				{
					result = (this._LastSensedStimuli = new TArray<FAIStimulus>(base.NativePtr + (IntPtr)FActorPerceptionBlueprintInfo.__PropertyOffset_LastSensedStimuli, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.LastSensedStimuli.CopyAssign(value);
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x060011A1 RID: 4513 RVA: 0x0001A4B9 File Offset: 0x000186B9
		// (set) Token: 0x060011A2 RID: 4514 RVA: 0x0001A4D2 File Offset: 0x000186D2
		public unsafe bool bIsHostile
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FActorPerceptionBlueprintInfo.__PropertyOffset_bIsHostile) & FActorPerceptionBlueprintInfo.__PropertyMask_bIsHostile) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FActorPerceptionBlueprintInfo.__PropertyOffset_bIsHostile) = ((*(base.NativePtr + (IntPtr)FActorPerceptionBlueprintInfo.__PropertyOffset_bIsHostile) & ~FActorPerceptionBlueprintInfo.__PropertyMask_bIsHostile) | (value ? FActorPerceptionBlueprintInfo.__PropertyMask_bIsHostile : 0));
			}
		}

		// Token: 0x060011A3 RID: 4515 RVA: 0x0001A502 File Offset: 0x00018702
		public FActorPerceptionBlueprintInfo()
		{
		}

		// Token: 0x060011A4 RID: 4516 RVA: 0x0001A50A File Offset: 0x0001870A
		public FActorPerceptionBlueprintInfo(AActor Target, TArray<FAIStimulus> LastSensedStimuli, bool bIsHostile)
		{
			this.Target = Target;
			this.LastSensedStimuli = LastSensedStimuli;
			this.bIsHostile = bIsHostile;
		}

		// Token: 0x060011A5 RID: 4517 RVA: 0x0001A527 File Offset: 0x00018727
		protected override IntPtr GetUStructPtr()
		{
			return FActorPerceptionBlueprintInfo.StaticStruct();
		}

		// Token: 0x060011A6 RID: 4518 RVA: 0x0001A533 File Offset: 0x00018733
		[NullableContext(2)]
		public FActorPerceptionBlueprintInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060011A7 RID: 4519 RVA: 0x0001A53D File Offset: 0x0001873D
		public FActorPerceptionBlueprintInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060011A8 RID: 4520 RVA: 0x0001A548 File Offset: 0x00018748
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FActorPerceptionBlueprintInfo(Pointer, false, true);
		}

		// Token: 0x060011A9 RID: 4521 RVA: 0x0001A552 File Offset: 0x00018752
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FActorPerceptionBlueprintInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040002DD RID: 733
		public const string __ObjectPath = "/Script/AIModule.ActorPerceptionBlueprintInfo";

		// Token: 0x040002DE RID: 734
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040002DF RID: 735
		internal static int __PropertyOffset_Target;

		// Token: 0x040002E0 RID: 736
		internal static int __PropertyOffset_LastSensedStimuli;

		// Token: 0x040002E1 RID: 737
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAIStimulus> _LastSensedStimuli;

		// Token: 0x040002E2 RID: 738
		internal static int __PropertyOffset_bIsHostile;

		// Token: 0x040002E3 RID: 739
		internal static byte __PropertyMask_bIsHostile;
	}
}
