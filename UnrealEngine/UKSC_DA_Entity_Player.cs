using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200056C RID: 1388
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Entity_Player")]
	[UnrealStructLayout(400, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 400)]
	public class UKSC_DA_Entity_Player : UKSC_DA_Entity, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007E54 RID: 32340 RVA: 0x000BB392 File Offset: 0x000B9592
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Entity_Player._ClassPtr;
		}

		// Token: 0x06007E55 RID: 32341 RVA: 0x000BB3A0 File Offset: 0x000B95A0
		public UKSC_DA_Entity_Player() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Entity_Player.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007E56 RID: 32342 RVA: 0x000BB3C8 File Offset: 0x000B95C8
		[NullableContext(1)]
		public UKSC_DA_Entity_Player(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Entity_Player.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700186D RID: 6253
		// (get) Token: 0x06007E57 RID: 32343 RVA: 0x000BB3FB File Offset: 0x000B95FB
		// (set) Token: 0x06007E58 RID: 32344 RVA: 0x000BB40B File Offset: 0x000B960B
		public unsafe float TurnRateScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Entity_Player.__PropertyOffset_TurnRateScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Entity_Player.__PropertyOffset_TurnRateScale) = value;
			}
		}

		// Token: 0x06007E59 RID: 32345 RVA: 0x000BB41C File Offset: 0x000B961C
		static UKSC_DA_Entity_Player()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Entity_Player");
		}

		// Token: 0x06007E5A RID: 32346 RVA: 0x000BB42A File Offset: 0x000B962A
		protected UKSC_DA_Entity_Player(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400371F RID: 14111
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Entity_Player";

		// Token: 0x04003720 RID: 14112
		private static IntPtr _ClassPtr;

		// Token: 0x04003721 RID: 14113
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003722 RID: 14114
		internal static int __PropertyOffset_TurnRateScale;
	}
}
