using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000370 RID: 880
	[UnrealObjectPath("/Script/KuroData.TraceSphereElement")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class UTraceSphereElement : UTraceBaseElement, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060059AE RID: 22958 RVA: 0x0007E632 File Offset: 0x0007C832
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTraceSphereElement._ClassPtr;
		}

		// Token: 0x060059AF RID: 22959 RVA: 0x0007E640 File Offset: 0x0007C840
		public UTraceSphereElement() : this(BuiltinUtils.AllocNativeUObject(UTraceSphereElement.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060059B0 RID: 22960 RVA: 0x0007E668 File Offset: 0x0007C868
		[NullableContext(1)]
		public UTraceSphereElement(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTraceSphereElement.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170011C5 RID: 4549
		// (get) Token: 0x060059B1 RID: 22961 RVA: 0x0007E69B File Offset: 0x0007C89B
		// (set) Token: 0x060059B2 RID: 22962 RVA: 0x0007E6AB File Offset: 0x0007C8AB
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTraceSphereElement.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTraceSphereElement.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x060059B3 RID: 22963 RVA: 0x0007E6BC File Offset: 0x0007C8BC
		static UTraceSphereElement()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroData.TraceSphereElement");
		}

		// Token: 0x060059B4 RID: 22964 RVA: 0x0007E6CA File Offset: 0x0007C8CA
		protected UTraceSphereElement(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002514 RID: 9492
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroData.TraceSphereElement";

		// Token: 0x04002515 RID: 9493
		private static IntPtr _ClassPtr;

		// Token: 0x04002516 RID: 9494
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002517 RID: 9495
		internal static int __PropertyOffset_Radius;
	}
}
