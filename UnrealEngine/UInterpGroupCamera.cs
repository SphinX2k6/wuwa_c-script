using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C80 RID: 3200
	[UnrealObjectPath("/Script/Engine.InterpGroupCamera")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class UInterpGroupCamera : UInterpGroup, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A280 RID: 41600 RVA: 0x000E6C0F File Offset: 0x000E4E0F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterpGroupCamera._ClassPtr;
		}

		// Token: 0x0600A281 RID: 41601 RVA: 0x000E6C1C File Offset: 0x000E4E1C
		public UInterpGroupCamera() : this(BuiltinUtils.AllocNativeUObject(UInterpGroupCamera.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A282 RID: 41602 RVA: 0x000E6C44 File Offset: 0x000E4E44
		[NullableContext(1)]
		public UInterpGroupCamera(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInterpGroupCamera.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170026AE RID: 9902
		// (get) Token: 0x0600A283 RID: 41603 RVA: 0x000E6C77 File Offset: 0x000E4E77
		// (set) Token: 0x0600A284 RID: 41604 RVA: 0x000E6C8B File Offset: 0x000E4E8B
		[Nullable(2)]
		public unsafe UCameraAnim CameraAnimInst
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCameraAnim>(base.NativePtr / (IntPtr)sizeof(void*) + UInterpGroupCamera.__PropertyOffset_CameraAnimInst);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UInterpGroupCamera.__PropertyOffset_CameraAnimInst, value);
			}
		}

		// Token: 0x170026AF RID: 9903
		// (get) Token: 0x0600A285 RID: 41605 RVA: 0x000E6CA0 File Offset: 0x000E4EA0
		// (set) Token: 0x0600A286 RID: 41606 RVA: 0x000E6CB0 File Offset: 0x000E4EB0
		public unsafe float CompressTolerance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInterpGroupCamera.__PropertyOffset_CompressTolerance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInterpGroupCamera.__PropertyOffset_CompressTolerance) = value;
			}
		}

		// Token: 0x0600A287 RID: 41607 RVA: 0x000E6CC1 File Offset: 0x000E4EC1
		static UInterpGroupCamera()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InterpGroupCamera");
		}

		// Token: 0x0600A288 RID: 41608 RVA: 0x000E6CCF File Offset: 0x000E4ECF
		protected UInterpGroupCamera(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400592E RID: 22830
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.InterpGroupCamera";

		// Token: 0x0400592F RID: 22831
		private static IntPtr _ClassPtr;

		// Token: 0x04005930 RID: 22832
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005931 RID: 22833
		internal static int __PropertyOffset_CameraAnimInst;

		// Token: 0x04005932 RID: 22834
		internal static int __PropertyOffset_CompressTolerance;
	}
}
