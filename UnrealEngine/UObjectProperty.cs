using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000753 RID: 1875
	[UnrealObjectPath("/Script/CoreUObject.ObjectProperty")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UObjectProperty : UObjectPropertyBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600631C RID: 25372 RVA: 0x0008E478 File Offset: 0x0008C678
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UObjectProperty._ClassPtr;
		}

		// Token: 0x0600631D RID: 25373 RVA: 0x0008E484 File Offset: 0x0008C684
		public UObjectProperty() : this(BuiltinUtils.AllocNativeUObject(UObjectProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600631E RID: 25374 RVA: 0x0008E4AC File Offset: 0x0008C6AC
		[NullableContext(1)]
		public UObjectProperty(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UObjectProperty.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600631F RID: 25375 RVA: 0x0008E4DF File Offset: 0x0008C6DF
		static UObjectProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.ObjectProperty");
		}

		// Token: 0x06006320 RID: 25376 RVA: 0x0008E4ED File Offset: 0x0008C6ED
		protected UObjectProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002F78 RID: 12152
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.ObjectProperty";

		// Token: 0x04002F79 RID: 12153
		private static IntPtr _ClassPtr;

		// Token: 0x04002F7A RID: 12154
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
