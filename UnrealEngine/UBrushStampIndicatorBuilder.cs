using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200153D RID: 5437
	[UnrealObjectPath("/Script/InteractiveToolsFramework.BrushStampIndicatorBuilder")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UBrushStampIndicatorBuilder : UInteractiveGizmoBuilder, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013BE9 RID: 80873 RVA: 0x001CFDE8 File Offset: 0x001CDFE8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBrushStampIndicatorBuilder._ClassPtr;
		}

		// Token: 0x06013BEA RID: 80874 RVA: 0x001CFDF4 File Offset: 0x001CDFF4
		public UBrushStampIndicatorBuilder() : this(BuiltinUtils.AllocNativeUObject(UBrushStampIndicatorBuilder.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013BEB RID: 80875 RVA: 0x001CFE1C File Offset: 0x001CE01C
		[NullableContext(1)]
		public UBrushStampIndicatorBuilder(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBrushStampIndicatorBuilder.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06013BEC RID: 80876 RVA: 0x001CFE4F File Offset: 0x001CE04F
		static UBrushStampIndicatorBuilder()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.BrushStampIndicatorBuilder");
		}

		// Token: 0x06013BED RID: 80877 RVA: 0x001CFE5D File Offset: 0x001CE05D
		protected UBrushStampIndicatorBuilder(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AADF RID: 43743
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.BrushStampIndicatorBuilder";

		// Token: 0x0400AAE0 RID: 43744
		private static IntPtr _ClassPtr;

		// Token: 0x0400AAE1 RID: 43745
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
