using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DD0 RID: 7632
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Decorator")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public abstract class UKSC_Decorator : UKSC_BaseObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D2C3 RID: 119491 RVA: 0x002B1974 File Offset: 0x002AFB74
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Decorator._ClassPtr;
		}

		// Token: 0x170075DE RID: 30174
		// (get) Token: 0x0601D2C4 RID: 119492 RVA: 0x002B1980 File Offset: 0x002AFB80
		// (set) Token: 0x0601D2C5 RID: 119493 RVA: 0x002B1994 File Offset: 0x002AFB94
		[Nullable(2)]
		public unsafe UKSC_DA_Decorator Da_Decorator_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Decorator>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Decorator.__PropertyOffset_Da_Decorator_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Decorator.__PropertyOffset_Da_Decorator_, value);
			}
		}

		// Token: 0x0601D2C6 RID: 119494 RVA: 0x002B19A9 File Offset: 0x002AFBA9
		static UKSC_Decorator()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Decorator");
		}

		// Token: 0x0601D2C7 RID: 119495 RVA: 0x002B19B8 File Offset: 0x002AFBB8
		protected UKSC_Decorator() : this(BuiltinUtils.AllocNativeUObject(UKSC_Decorator.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D2C8 RID: 119496 RVA: 0x002B19E0 File Offset: 0x002AFBE0
		protected UKSC_Decorator(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FD6D RID: 64877
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Decorator";

		// Token: 0x0400FD6E RID: 64878
		private static IntPtr _ClassPtr;

		// Token: 0x0400FD6F RID: 64879
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FD70 RID: 64880
		internal static int __PropertyOffset_Da_Decorator_;
	}
}
