using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000F5 RID: 245
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.AIPerceptionSystem")]
	[UnrealStructLayout(336, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 336)]
	public class UAIPerceptionSystem : UAISubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001327 RID: 4903 RVA: 0x0001C542 File Offset: 0x0001A742
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAIPerceptionSystem._ClassPtr;
		}

		// Token: 0x06001328 RID: 4904 RVA: 0x0001C550 File Offset: 0x0001A750
		public UAIPerceptionSystem() : this(BuiltinUtils.AllocNativeUObject(UAIPerceptionSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001329 RID: 4905 RVA: 0x0001C578 File Offset: 0x0001A778
		public UAIPerceptionSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAIPerceptionSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x0600132A RID: 4906 RVA: 0x0001C5AC File Offset: 0x0001A7AC
		// (set) Token: 0x0600132B RID: 4907 RVA: 0x0001C5E5 File Offset: 0x0001A7E5
		public TArray<UAISense> Senses
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UAISense> result;
				if ((result = this._Senses) == null)
				{
					result = (this._Senses = new TArray<UAISense>(base.NativePtr + (IntPtr)UAIPerceptionSystem.__PropertyOffset_Senses, this));
				}
				return result;
			}
			set
			{
				this.Senses.CopyAssign(value);
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x0600132C RID: 4908 RVA: 0x0001C5F3 File Offset: 0x0001A7F3
		// (set) Token: 0x0600132D RID: 4909 RVA: 0x0001C603 File Offset: 0x0001A803
		public unsafe float PerceptionAgingRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAIPerceptionSystem.__PropertyOffset_PerceptionAgingRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAIPerceptionSystem.__PropertyOffset_PerceptionAgingRate) = value;
			}
		}

		// Token: 0x0600132E RID: 4910 RVA: 0x0001C614 File Offset: 0x0001A814
		[NullableContext(2)]
		public static void ReportPerceptionEvent(UObject WorldContextObject, UAISenseEvent PerceptionEvent)
		{
			UAIPerceptionSystem.__ReportPerceptionEvent_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (PerceptionEvent != null) ? PerceptionEvent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600132F RID: 4911 RVA: 0x0001C63B File Offset: 0x0001A83B
		[NullableContext(2)]
		public void ReportEvent(UAISenseEvent PerceptionEvent)
		{
			UAIPerceptionSystem.__ReportEvent_Internal(base.NativePtr, (PerceptionEvent != null) ? PerceptionEvent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06001330 RID: 4912 RVA: 0x0001C658 File Offset: 0x0001A858
		[NullableContext(2)]
		public static bool RegisterPerceptionStimuliSource(UObject WorldContextObject, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UAISense> Sense, AActor Target)
		{
			return UAIPerceptionSystem.__RegisterPerceptionStimuliSource_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Sense._NativePtr, (Target != null) ? Target.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06001331 RID: 4913 RVA: 0x0001C685 File Offset: 0x0001A885
		[NullableContext(2)]
		public void OnPerceptionStimuliSourceEndPlay(AActor Actor, EEndPlayReason EndPlayReason)
		{
			UAIPerceptionSystem.__OnPerceptionStimuliSourceEndPlay_Internal(base.NativePtr, (Actor != null) ? Actor.NativePtr : IntPtr.Zero, EndPlayReason);
		}

		// Token: 0x06001332 RID: 4914 RVA: 0x0001C6A8 File Offset: 0x0001A8A8
		[NullableContext(2)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static TSubclassOf<UAISense> GetSenseClassForStimulus(UObject WorldContextObject, in FAIStimulus Stimulus)
		{
			return UAIPerceptionSystem.__GetSenseClassForStimulus_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Stimulus ?? new FAIStimulus()).NativePtr);
		}

		// Token: 0x06001333 RID: 4915
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReportPerceptionEvent_Internal(IntPtr WorldContextObject, IntPtr PerceptionEvent);

		// Token: 0x06001334 RID: 4916
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReportEvent_Internal(IntPtr @this, IntPtr PerceptionEvent);

		// Token: 0x06001335 RID: 4917
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __RegisterPerceptionStimuliSource_Internal(IntPtr WorldContextObject, IntPtr Sense, IntPtr Target);

		// Token: 0x06001336 RID: 4918
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnPerceptionStimuliSourceEndPlay_Internal(IntPtr @this, IntPtr Actor, TEnumAsByte<EEndPlayReason> EndPlayReason);

		// Token: 0x06001337 RID: 4919
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSenseClassForStimulus_Internal(IntPtr WorldContextObject, IntPtr Stimulus);

		// Token: 0x06001338 RID: 4920 RVA: 0x0001C6D4 File Offset: 0x0001A8D4
		static UAIPerceptionSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.AIPerceptionSystem");
		}

		// Token: 0x06001339 RID: 4921 RVA: 0x0001C6E2 File Offset: 0x0001A8E2
		protected UAIPerceptionSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400036F RID: 879
		public new const string __ObjectPath = "/Script/AIModule.AIPerceptionSystem";

		// Token: 0x04000370 RID: 880
		private static IntPtr _ClassPtr;

		// Token: 0x04000371 RID: 881
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000372 RID: 882
		internal static int __PropertyOffset_Senses;

		// Token: 0x04000373 RID: 883
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UAISense> _Senses;

		// Token: 0x04000374 RID: 884
		internal static int __PropertyOffset_PerceptionAgingRate;
	}
}
