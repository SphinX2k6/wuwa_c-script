using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000754 RID: 1876
	[UnrealObjectPath("/Script/CoreUObject.ObjectPropertyBase")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public abstract class UObjectPropertyBase : UProperty, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006321 RID: 25377 RVA: 0x0008E4F6 File Offset: 0x0008C6F6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UObjectPropertyBase._ClassPtr;
		}

		// Token: 0x06006322 RID: 25378 RVA: 0x0008E502 File Offset: 0x0008C702
		static UObjectPropertyBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.ObjectPropertyBase");
		}

		// Token: 0x06006323 RID: 25379 RVA: 0x0008E510 File Offset: 0x0008C710
		protected UObjectPropertyBase() : this(BuiltinUtils.AllocNativeUObject(UObjectPropertyBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006324 RID: 25380 RVA: 0x0008E538 File Offset: 0x0008C738
		protected UObjectPropertyBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002F7B RID: 12155
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.ObjectPropertyBase";

		// Token: 0x04002F7C RID: 12156
		private static IntPtr _ClassPtr;

		// Token: 0x04002F7D RID: 12157
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
