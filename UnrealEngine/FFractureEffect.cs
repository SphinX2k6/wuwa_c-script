using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000BF2 RID: 3058
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.FractureEffect")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FFractureEffect : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060096E6 RID: 38630 RVA: 0x000D73CB File Offset: 0x000D55CB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFractureEffect._ScriptStructPtr != 0) ? FFractureEffect._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.FractureEffect", ref FFractureEffect._ScriptStructPtr);
		}

		// Token: 0x17002434 RID: 9268
		// (get) Token: 0x060096E7 RID: 38631 RVA: 0x000D73EF File Offset: 0x000D55EF
		// (set) Token: 0x060096E8 RID: 38632 RVA: 0x000D7403 File Offset: 0x000D5603
		public unsafe UParticleSystem ParticleSystem
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UParticleSystem>(base.NativePtr / (IntPtr)sizeof(void*) + FFractureEffect.__PropertyOffset_ParticleSystem);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FFractureEffect.__PropertyOffset_ParticleSystem, value);
			}
		}

		// Token: 0x17002435 RID: 9269
		// (get) Token: 0x060096E9 RID: 38633 RVA: 0x000D7418 File Offset: 0x000D5618
		// (set) Token: 0x060096EA RID: 38634 RVA: 0x000D742C File Offset: 0x000D562C
		public unsafe USoundBase Sound
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USoundBase>(base.NativePtr / (IntPtr)sizeof(void*) + FFractureEffect.__PropertyOffset_Sound);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FFractureEffect.__PropertyOffset_Sound, value);
			}
		}

		// Token: 0x060096EB RID: 38635 RVA: 0x000D7441 File Offset: 0x000D5641
		public FFractureEffect()
		{
		}

		// Token: 0x060096EC RID: 38636 RVA: 0x000D7449 File Offset: 0x000D5649
		[NullableContext(1)]
		public FFractureEffect(UParticleSystem ParticleSystem, USoundBase Sound)
		{
			this.ParticleSystem = ParticleSystem;
			this.Sound = Sound;
		}

		// Token: 0x060096ED RID: 38637 RVA: 0x000D745F File Offset: 0x000D565F
		protected override IntPtr GetUStructPtr()
		{
			return FFractureEffect.StaticStruct();
		}

		// Token: 0x060096EE RID: 38638 RVA: 0x000D746B File Offset: 0x000D566B
		public FFractureEffect(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060096EF RID: 38639 RVA: 0x000D7475 File Offset: 0x000D5675
		public FFractureEffect(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060096F0 RID: 38640 RVA: 0x000D7480 File Offset: 0x000D5680
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FFractureEffect(Pointer, false, true);
		}

		// Token: 0x060096F1 RID: 38641 RVA: 0x000D748A File Offset: 0x000D568A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FFractureEffect(Pointer, MemoryOwner);
		}

		// Token: 0x040054A2 RID: 21666
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.FractureEffect";

		// Token: 0x040054A3 RID: 21667
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040054A4 RID: 21668
		internal static int __PropertyOffset_ParticleSystem;

		// Token: 0x040054A5 RID: 21669
		internal static int __PropertyOffset_Sound;
	}
}
