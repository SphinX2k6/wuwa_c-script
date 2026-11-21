using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000158 RID: 344
	[UnrealObjectPath("/Script/CoreUObject.WeakObjectProperty")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UWeakObjectProperty : UObjectPropertyBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001342 RID: 4930 RVA: 0x0001E675 File Offset: 0x0001C875
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWeakObjectProperty._ClassPtr;
		}

		// Token: 0x06001343 RID: 4931 RVA: 0x0001E684 File Offset: 0x0001C884
		public UWeakObjectProperty() : this(BuiltinUtils.AllocNativeUObject(UWeakObjectProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001344 RID: 4932 RVA: 0x0001E6AC File Offset: 0x0001C8AC
		[NullableContext(1)]
		public UWeakObjectProperty(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWeakObjectProperty.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06001345 RID: 4933 RVA: 0x0001E6DF File Offset: 0x0001C8DF
		static UWeakObjectProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.WeakObjectProperty");
		}

		// Token: 0x06001346 RID: 4934 RVA: 0x0001E6ED File Offset: 0x0001C8ED
		protected UWeakObjectProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400061F RID: 1567
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.WeakObjectProperty";

		// Token: 0x04000620 RID: 1568
		private static IntPtr _ClassPtr;

		// Token: 0x04000621 RID: 1569
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
