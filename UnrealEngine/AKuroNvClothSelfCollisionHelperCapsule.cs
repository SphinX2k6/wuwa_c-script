using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B85 RID: 7045
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroNvClothSelfCollisionHelperCapsule")]
	[UnrealStructLayout(1064, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1064)]
	public class AKuroNvClothSelfCollisionHelperCapsule : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601ABAE RID: 109486 RVA: 0x002761E5 File Offset: 0x002743E5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroNvClothSelfCollisionHelperCapsule._ClassPtr;
		}

		// Token: 0x0601ABAF RID: 109487 RVA: 0x002761F4 File Offset: 0x002743F4
		public AKuroNvClothSelfCollisionHelperCapsule() : this(BuiltinUtils.AllocNativeUObject(AKuroNvClothSelfCollisionHelperCapsule.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601ABB0 RID: 109488 RVA: 0x0027621C File Offset: 0x0027441C
		[NullableContext(1)]
		public AKuroNvClothSelfCollisionHelperCapsule(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroNvClothSelfCollisionHelperCapsule.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006B81 RID: 27521
		// (get) Token: 0x0601ABB1 RID: 109489 RVA: 0x0027624F File Offset: 0x0027444F
		// (set) Token: 0x0601ABB2 RID: 109490 RVA: 0x0027625F File Offset: 0x0027445F
		public unsafe float Length
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroNvClothSelfCollisionHelperCapsule.__PropertyOffset_Length);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroNvClothSelfCollisionHelperCapsule.__PropertyOffset_Length) = value;
			}
		}

		// Token: 0x17006B82 RID: 27522
		// (get) Token: 0x0601ABB3 RID: 109491 RVA: 0x00276270 File Offset: 0x00274470
		// (set) Token: 0x0601ABB4 RID: 109492 RVA: 0x00276280 File Offset: 0x00274480
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroNvClothSelfCollisionHelperCapsule.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroNvClothSelfCollisionHelperCapsule.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x17006B83 RID: 27523
		// (get) Token: 0x0601ABB5 RID: 109493 RVA: 0x00276291 File Offset: 0x00274491
		// (set) Token: 0x0601ABB6 RID: 109494 RVA: 0x002762A5 File Offset: 0x002744A5
		public unsafe UStaticMeshComponent Sphere0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroNvClothSelfCollisionHelperCapsule.__PropertyOffset_Sphere0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroNvClothSelfCollisionHelperCapsule.__PropertyOffset_Sphere0, value);
			}
		}

		// Token: 0x17006B84 RID: 27524
		// (get) Token: 0x0601ABB7 RID: 109495 RVA: 0x002762BA File Offset: 0x002744BA
		// (set) Token: 0x0601ABB8 RID: 109496 RVA: 0x002762CE File Offset: 0x002744CE
		public unsafe UStaticMeshComponent Sphere1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroNvClothSelfCollisionHelperCapsule.__PropertyOffset_Sphere1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroNvClothSelfCollisionHelperCapsule.__PropertyOffset_Sphere1, value);
			}
		}

		// Token: 0x0601ABB9 RID: 109497 RVA: 0x002762E3 File Offset: 0x002744E3
		static AKuroNvClothSelfCollisionHelperCapsule()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroNvClothSelfCollisionHelperCapsule");
		}

		// Token: 0x0601ABBA RID: 109498 RVA: 0x002762F1 File Offset: 0x002744F1
		protected AKuroNvClothSelfCollisionHelperCapsule(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E75A RID: 59226
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroNvClothSelfCollisionHelperCapsule";

		// Token: 0x0400E75B RID: 59227
		private static IntPtr _ClassPtr;

		// Token: 0x0400E75C RID: 59228
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E75D RID: 59229
		internal static int __PropertyOffset_Length;

		// Token: 0x0400E75E RID: 59230
		internal static int __PropertyOffset_Radius;

		// Token: 0x0400E75F RID: 59231
		internal static int __PropertyOffset_Sphere0;

		// Token: 0x0400E760 RID: 59232
		internal static int __PropertyOffset_Sphere1;
	}
}
