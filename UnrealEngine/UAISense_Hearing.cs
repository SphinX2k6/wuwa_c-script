using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200010B RID: 267
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.AISense_Hearing")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UAISense_Hearing : UAISense, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060013F5 RID: 5109 RVA: 0x0001D74A File Offset: 0x0001B94A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAISense_Hearing._ClassPtr;
		}

		// Token: 0x060013F6 RID: 5110 RVA: 0x0001D758 File Offset: 0x0001B958
		public UAISense_Hearing() : this(BuiltinUtils.AllocNativeUObject(UAISense_Hearing.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060013F7 RID: 5111 RVA: 0x0001D780 File Offset: 0x0001B980
		public UAISense_Hearing(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAISense_Hearing.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x060013F8 RID: 5112 RVA: 0x0001D7B4 File Offset: 0x0001B9B4
		// (set) Token: 0x060013F9 RID: 5113 RVA: 0x0001D7ED File Offset: 0x0001B9ED
		public TArray<FAINoiseEvent> NoiseEvents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAINoiseEvent> result;
				if ((result = this._NoiseEvents) == null)
				{
					result = (this._NoiseEvents = new TArray<FAINoiseEvent>(base.NativePtr + (IntPtr)UAISense_Hearing.__PropertyOffset_NoiseEvents, this));
				}
				return result;
			}
			set
			{
				this.NoiseEvents.CopyAssign(value);
			}
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x060013FA RID: 5114 RVA: 0x0001D7FB File Offset: 0x0001B9FB
		// (set) Token: 0x060013FB RID: 5115 RVA: 0x0001D80B File Offset: 0x0001BA0B
		public unsafe float SpeedOfSoundSq
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAISense_Hearing.__PropertyOffset_SpeedOfSoundSq);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAISense_Hearing.__PropertyOffset_SpeedOfSoundSq) = value;
			}
		}

		// Token: 0x060013FC RID: 5116 RVA: 0x0001D81C File Offset: 0x0001BA1C
		[NullableContext(2)]
		public static void ReportNoiseEvent(UObject WorldContextObject, FVector NoiseLocation, float Loudness = 1f, AActor Instigator = null, float MaxRange = 0f, FName Tag = default(FName))
		{
			UAISense_Hearing.__ReportNoiseEvent_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, NoiseLocation, Loudness, (Instigator != null) ? Instigator.NativePtr : IntPtr.Zero, MaxRange, Tag);
		}

		// Token: 0x060013FD RID: 5117
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReportNoiseEvent_Internal(IntPtr WorldContextObject, FVector NoiseLocation, float Loudness, IntPtr Instigator, float MaxRange, FName Tag);

		// Token: 0x060013FE RID: 5118 RVA: 0x0001D849 File Offset: 0x0001BA49
		static UAISense_Hearing()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.AISense_Hearing");
		}

		// Token: 0x060013FF RID: 5119 RVA: 0x0001D857 File Offset: 0x0001BA57
		protected UAISense_Hearing(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040003D9 RID: 985
		public new const string __ObjectPath = "/Script/AIModule.AISense_Hearing";

		// Token: 0x040003DA RID: 986
		private static IntPtr _ClassPtr;

		// Token: 0x040003DB RID: 987
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040003DC RID: 988
		internal static int __PropertyOffset_NoiseEvents;

		// Token: 0x040003DD RID: 989
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAINoiseEvent> _NoiseEvents;

		// Token: 0x040003DE RID: 990
		internal static int __PropertyOffset_SpeedOfSoundSq;
	}
}
