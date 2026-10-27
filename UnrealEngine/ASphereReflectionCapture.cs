using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001174 RID: 4468
	[UnrealObjectPath("/Script/Engine.SphereReflectionCapture")]
	[UnrealStructLayout(1072, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1072)]
	public class ASphereReflectionCapture : AReflectionCapture, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010526 RID: 66854 RVA: 0x00180AC1 File Offset: 0x0017ECC1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ASphereReflectionCapture._ClassPtr;
		}

		// Token: 0x06010527 RID: 66855 RVA: 0x00180AD0 File Offset: 0x0017ECD0
		public ASphereReflectionCapture() : this(BuiltinUtils.AllocNativeUObject(ASphereReflectionCapture.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010528 RID: 66856 RVA: 0x00180AF8 File Offset: 0x0017ECF8
		[NullableContext(1)]
		public ASphereReflectionCapture(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ASphereReflectionCapture.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003FEE RID: 16366
		// (get) Token: 0x06010529 RID: 66857 RVA: 0x00180B2B File Offset: 0x0017ED2B
		// (set) Token: 0x0601052A RID: 66858 RVA: 0x00180B3F File Offset: 0x0017ED3F
		[Nullable(2)]
		public unsafe UDrawSphereComponent DrawCaptureRadius
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDrawSphereComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ASphereReflectionCapture.__PropertyOffset_DrawCaptureRadius);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ASphereReflectionCapture.__PropertyOffset_DrawCaptureRadius, value);
			}
		}

		// Token: 0x0601052B RID: 66859 RVA: 0x00180B54 File Offset: 0x0017ED54
		static ASphereReflectionCapture()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SphereReflectionCapture");
		}

		// Token: 0x0601052C RID: 66860 RVA: 0x00180B62 File Offset: 0x0017ED62
		protected ASphereReflectionCapture(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008C71 RID: 35953
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SphereReflectionCapture";

		// Token: 0x04008C72 RID: 35954
		private static IntPtr _ClassPtr;

		// Token: 0x04008C73 RID: 35955
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008C74 RID: 35956
		internal static int __PropertyOffset_DrawCaptureRadius;
	}
}
