using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007EE RID: 2030
	[UnrealObjectPath("/Script/SharpherealTest.SharpherealTestSimpleClassDerived")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class USharpherealTestSimpleClassDerived : USharpherealTestSimpleClass, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600ADB4 RID: 44468 RVA: 0x00101150 File Offset: 0x000FF350
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USharpherealTestSimpleClassDerived._ClassPtr;
		}

		// Token: 0x0600ADB5 RID: 44469 RVA: 0x0010115C File Offset: 0x000FF35C
		public USharpherealTestSimpleClassDerived() : this(BuiltinUtils.AllocNativeUObject(USharpherealTestSimpleClassDerived.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600ADB6 RID: 44470 RVA: 0x00101184 File Offset: 0x000FF384
		[NullableContext(1)]
		public USharpherealTestSimpleClassDerived(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USharpherealTestSimpleClassDerived.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600ADB7 RID: 44471 RVA: 0x001011B7 File Offset: 0x000FF3B7
		static USharpherealTestSimpleClassDerived()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SharpherealTest.SharpherealTestSimpleClassDerived");
		}

		// Token: 0x0600ADB8 RID: 44472 RVA: 0x001011C5 File Offset: 0x000FF3C5
		protected USharpherealTestSimpleClassDerived(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004AF2 RID: 19186
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SharpherealTest.SharpherealTestSimpleClassDerived";

		// Token: 0x04004AF3 RID: 19187
		private static IntPtr _ClassPtr;

		// Token: 0x04004AF4 RID: 19188
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
