using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000561 RID: 1377
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_BaseObject")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UKSC_BaseObject : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007DA8 RID: 32168 RVA: 0x000BA54B File Offset: 0x000B874B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_BaseObject._ClassPtr;
		}

		// Token: 0x06007DA9 RID: 32169 RVA: 0x000BA558 File Offset: 0x000B8758
		public UKSC_BaseObject() : this(BuiltinUtils.AllocNativeUObject(UKSC_BaseObject.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007DAA RID: 32170 RVA: 0x000BA580 File Offset: 0x000B8780
		[NullableContext(1)]
		public UKSC_BaseObject(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_BaseObject.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001837 RID: 6199
		// (get) Token: 0x06007DAB RID: 32171 RVA: 0x000BA5B3 File Offset: 0x000B87B3
		// (set) Token: 0x06007DAC RID: 32172 RVA: 0x000BA5C7 File Offset: 0x000B87C7
		[Nullable(2)]
		public unsafe UKSC_World KscWorld
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_World>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_BaseObject.__PropertyOffset_KscWorld);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_BaseObject.__PropertyOffset_KscWorld, value);
			}
		}

		// Token: 0x06007DAD RID: 32173 RVA: 0x000BA5DC File Offset: 0x000B87DC
		static UKSC_BaseObject()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_BaseObject");
		}

		// Token: 0x06007DAE RID: 32174 RVA: 0x000BA5EA File Offset: 0x000B87EA
		protected UKSC_BaseObject(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040036C1 RID: 14017
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_BaseObject";

		// Token: 0x040036C2 RID: 14018
		private static IntPtr _ClassPtr;

		// Token: 0x040036C3 RID: 14019
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040036C4 RID: 14020
		internal static int __PropertyOffset_KscWorld;
	}
}
