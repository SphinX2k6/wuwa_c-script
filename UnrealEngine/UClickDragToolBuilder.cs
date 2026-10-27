using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001540 RID: 5440
	[UnrealObjectPath("/Script/InteractiveToolsFramework.ClickDragToolBuilder")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UClickDragToolBuilder : UInteractiveToolBuilder, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013BFA RID: 80890 RVA: 0x001CFF86 File Offset: 0x001CE186
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UClickDragToolBuilder._ClassPtr;
		}

		// Token: 0x06013BFB RID: 80891 RVA: 0x001CFF94 File Offset: 0x001CE194
		public UClickDragToolBuilder() : this(BuiltinUtils.AllocNativeUObject(UClickDragToolBuilder.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013BFC RID: 80892 RVA: 0x001CFFBC File Offset: 0x001CE1BC
		[NullableContext(1)]
		public UClickDragToolBuilder(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UClickDragToolBuilder.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06013BFD RID: 80893 RVA: 0x001CFFEF File Offset: 0x001CE1EF
		static UClickDragToolBuilder()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.ClickDragToolBuilder");
		}

		// Token: 0x06013BFE RID: 80894 RVA: 0x001CFFFD File Offset: 0x001CE1FD
		protected UClickDragToolBuilder(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AAE9 RID: 43753
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.ClickDragToolBuilder";

		// Token: 0x0400AAEA RID: 43754
		private static IntPtr _ClassPtr;

		// Token: 0x0400AAEB RID: 43755
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
