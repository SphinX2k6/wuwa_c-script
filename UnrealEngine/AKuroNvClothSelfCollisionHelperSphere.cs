using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B86 RID: 7046
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroNvClothSelfCollisionHelperSphere")]
	[UnrealStructLayout(1048, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1048)]
	public class AKuroNvClothSelfCollisionHelperSphere : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601ABBB RID: 109499 RVA: 0x002762FA File Offset: 0x002744FA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroNvClothSelfCollisionHelperSphere._ClassPtr;
		}

		// Token: 0x0601ABBC RID: 109500 RVA: 0x00276308 File Offset: 0x00274508
		public AKuroNvClothSelfCollisionHelperSphere() : this(BuiltinUtils.AllocNativeUObject(AKuroNvClothSelfCollisionHelperSphere.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601ABBD RID: 109501 RVA: 0x00276330 File Offset: 0x00274530
		[NullableContext(1)]
		public AKuroNvClothSelfCollisionHelperSphere(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroNvClothSelfCollisionHelperSphere.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006B85 RID: 27525
		// (get) Token: 0x0601ABBE RID: 109502 RVA: 0x00276363 File Offset: 0x00274563
		// (set) Token: 0x0601ABBF RID: 109503 RVA: 0x00276373 File Offset: 0x00274573
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroNvClothSelfCollisionHelperSphere.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroNvClothSelfCollisionHelperSphere.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x0601ABC0 RID: 109504 RVA: 0x00276384 File Offset: 0x00274584
		static AKuroNvClothSelfCollisionHelperSphere()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroNvClothSelfCollisionHelperSphere");
		}

		// Token: 0x0601ABC1 RID: 109505 RVA: 0x00276392 File Offset: 0x00274592
		protected AKuroNvClothSelfCollisionHelperSphere(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E761 RID: 59233
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroNvClothSelfCollisionHelperSphere";

		// Token: 0x0400E762 RID: 59234
		private static IntPtr _ClassPtr;

		// Token: 0x0400E763 RID: 59235
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E764 RID: 59236
		internal static int __PropertyOffset_Radius;
	}
}
