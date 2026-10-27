using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D30 RID: 7472
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Buff_Push")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class UKSC_Buff_Push : UKSC_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CA71 RID: 117361 RVA: 0x002A5B7F File Offset: 0x002A3D7F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Buff_Push._ClassPtr;
		}

		// Token: 0x0601CA72 RID: 117362 RVA: 0x002A5B8C File Offset: 0x002A3D8C
		public UKSC_Buff_Push() : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_Push.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CA73 RID: 117363 RVA: 0x002A5BB4 File Offset: 0x002A3DB4
		[NullableContext(1)]
		public UKSC_Buff_Push(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_Push.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700734A RID: 29514
		// (get) Token: 0x0601CA74 RID: 117364 RVA: 0x002A5BE7 File Offset: 0x002A3DE7
		// (set) Token: 0x0601CA75 RID: 117365 RVA: 0x002A5BFB File Offset: 0x002A3DFB
		[Nullable(2)]
		public unsafe UKSC_DA_Buff_Push DaBuffPush_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff_Push>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_Push.__PropertyOffset_DaBuffPush_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_Push.__PropertyOffset_DaBuffPush_, value);
			}
		}

		// Token: 0x0601CA76 RID: 117366 RVA: 0x002A5C10 File Offset: 0x002A3E10
		static UKSC_Buff_Push()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Buff_Push");
		}

		// Token: 0x0601CA77 RID: 117367 RVA: 0x002A5C1E File Offset: 0x002A3E1E
		protected UKSC_Buff_Push(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F888 RID: 63624
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Buff_Push";

		// Token: 0x0400F889 RID: 63625
		private static IntPtr _ClassPtr;

		// Token: 0x0400F88A RID: 63626
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F88B RID: 63627
		internal static int __PropertyOffset_DaBuffPush_;
	}
}
