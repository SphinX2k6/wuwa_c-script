using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E5F RID: 7775
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_WorldBoundsRound")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UKSC_WorldBoundsRound : UKSC_WorldBounds, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DA13 RID: 121363 RVA: 0x002BBE72 File Offset: 0x002BA072
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_WorldBoundsRound._ClassPtr;
		}

		// Token: 0x0601DA14 RID: 121364 RVA: 0x002BBE80 File Offset: 0x002BA080
		public UKSC_WorldBoundsRound() : this(BuiltinUtils.AllocNativeUObject(UKSC_WorldBoundsRound.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DA15 RID: 121365 RVA: 0x002BBEA8 File Offset: 0x002BA0A8
		[NullableContext(1)]
		public UKSC_WorldBoundsRound(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_WorldBoundsRound.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007758 RID: 30552
		// (get) Token: 0x0601DA16 RID: 121366 RVA: 0x002BBEDB File Offset: 0x002BA0DB
		// (set) Token: 0x0601DA17 RID: 121367 RVA: 0x002BBEEF File Offset: 0x002BA0EF
		[Nullable(2)]
		public unsafe UKSC_DA_WorldBoundsRound DA_WorldBounds
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_WorldBoundsRound>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_WorldBoundsRound.__PropertyOffset_DA_WorldBounds);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_WorldBoundsRound.__PropertyOffset_DA_WorldBounds, value);
			}
		}

		// Token: 0x0601DA18 RID: 121368 RVA: 0x002BBF04 File Offset: 0x002BA104
		static UKSC_WorldBoundsRound()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_WorldBoundsRound");
		}

		// Token: 0x0601DA19 RID: 121369 RVA: 0x002BBF12 File Offset: 0x002BA112
		protected UKSC_WorldBoundsRound(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040100E7 RID: 65767
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_WorldBoundsRound";

		// Token: 0x040100E8 RID: 65768
		private static IntPtr _ClassPtr;

		// Token: 0x040100E9 RID: 65769
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040100EA RID: 65770
		internal static int __PropertyOffset_DA_WorldBounds;
	}
}
