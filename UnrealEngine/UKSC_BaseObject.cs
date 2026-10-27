using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001CFD RID: 7421
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_BaseObject")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UKSC_BaseObject : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C8E7 RID: 116967 RVA: 0x002A3763 File Offset: 0x002A1963
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_BaseObject._ClassPtr;
		}

		// Token: 0x0601C8E8 RID: 116968 RVA: 0x002A3770 File Offset: 0x002A1970
		public UKSC_BaseObject() : this(BuiltinUtils.AllocNativeUObject(UKSC_BaseObject.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C8E9 RID: 116969 RVA: 0x002A3798 File Offset: 0x002A1998
		[NullableContext(1)]
		public UKSC_BaseObject(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_BaseObject.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700730D RID: 29453
		// (get) Token: 0x0601C8EA RID: 116970 RVA: 0x002A37CB File Offset: 0x002A19CB
		// (set) Token: 0x0601C8EB RID: 116971 RVA: 0x002A37DF File Offset: 0x002A19DF
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

		// Token: 0x0601C8EC RID: 116972 RVA: 0x002A37F4 File Offset: 0x002A19F4
		static UKSC_BaseObject()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_BaseObject");
		}

		// Token: 0x0601C8ED RID: 116973 RVA: 0x002A3802 File Offset: 0x002A1A02
		protected UKSC_BaseObject(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F7AB RID: 63403
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_BaseObject";

		// Token: 0x0400F7AC RID: 63404
		private static IntPtr _ClassPtr;

		// Token: 0x0400F7AD RID: 63405
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F7AE RID: 63406
		internal static int __PropertyOffset_KscWorld;
	}
}
