using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020017FE RID: 6142
	[UnrealObjectPath("/Script/KuroData.TraceSphereElement")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class UTraceSphereElement : UTraceBaseElement, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06016BD8 RID: 93144 RVA: 0x00212F12 File Offset: 0x00211112
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTraceSphereElement._ClassPtr;
		}

		// Token: 0x06016BD9 RID: 93145 RVA: 0x00212F20 File Offset: 0x00211120
		public UTraceSphereElement() : this(BuiltinUtils.AllocNativeUObject(UTraceSphereElement.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06016BDA RID: 93146 RVA: 0x00212F48 File Offset: 0x00211148
		[NullableContext(1)]
		public UTraceSphereElement(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTraceSphereElement.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005BF1 RID: 23537
		// (get) Token: 0x06016BDB RID: 93147 RVA: 0x00212F7B File Offset: 0x0021117B
		// (set) Token: 0x06016BDC RID: 93148 RVA: 0x00212F8B File Offset: 0x0021118B
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

		// Token: 0x06016BDD RID: 93149 RVA: 0x00212F9C File Offset: 0x0021119C
		static UTraceSphereElement()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroData.TraceSphereElement");
		}

		// Token: 0x06016BDE RID: 93150 RVA: 0x00212FAA File Offset: 0x002111AA
		protected UTraceSphereElement(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C57C RID: 50556
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroData.TraceSphereElement";

		// Token: 0x0400C57D RID: 50557
		private static IntPtr _ClassPtr;

		// Token: 0x0400C57E RID: 50558
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C57F RID: 50559
		internal static int __PropertyOffset_Radius;
	}
}
