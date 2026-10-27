using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B84 RID: 7044
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroNvClothSelfCollisionHelperBox")]
	[UnrealStructLayout(1056, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1056)]
	public class AKuroNvClothSelfCollisionHelperBox : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601ABA3 RID: 109475 RVA: 0x00276102 File Offset: 0x00274302
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroNvClothSelfCollisionHelperBox._ClassPtr;
		}

		// Token: 0x0601ABA4 RID: 109476 RVA: 0x00276110 File Offset: 0x00274310
		public AKuroNvClothSelfCollisionHelperBox() : this(BuiltinUtils.AllocNativeUObject(AKuroNvClothSelfCollisionHelperBox.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601ABA5 RID: 109477 RVA: 0x00276138 File Offset: 0x00274338
		[NullableContext(1)]
		public AKuroNvClothSelfCollisionHelperBox(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroNvClothSelfCollisionHelperBox.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006B7E RID: 27518
		// (get) Token: 0x0601ABA6 RID: 109478 RVA: 0x0027616B File Offset: 0x0027436B
		// (set) Token: 0x0601ABA7 RID: 109479 RVA: 0x0027617B File Offset: 0x0027437B
		public unsafe float X
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroNvClothSelfCollisionHelperBox.__PropertyOffset_X);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroNvClothSelfCollisionHelperBox.__PropertyOffset_X) = value;
			}
		}

		// Token: 0x17006B7F RID: 27519
		// (get) Token: 0x0601ABA8 RID: 109480 RVA: 0x0027618C File Offset: 0x0027438C
		// (set) Token: 0x0601ABA9 RID: 109481 RVA: 0x0027619C File Offset: 0x0027439C
		public unsafe float Y
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroNvClothSelfCollisionHelperBox.__PropertyOffset_Y);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroNvClothSelfCollisionHelperBox.__PropertyOffset_Y) = value;
			}
		}

		// Token: 0x17006B80 RID: 27520
		// (get) Token: 0x0601ABAA RID: 109482 RVA: 0x002761AD File Offset: 0x002743AD
		// (set) Token: 0x0601ABAB RID: 109483 RVA: 0x002761BD File Offset: 0x002743BD
		public unsafe float Z
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroNvClothSelfCollisionHelperBox.__PropertyOffset_Z);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroNvClothSelfCollisionHelperBox.__PropertyOffset_Z) = value;
			}
		}

		// Token: 0x0601ABAC RID: 109484 RVA: 0x002761CE File Offset: 0x002743CE
		static AKuroNvClothSelfCollisionHelperBox()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroNvClothSelfCollisionHelperBox");
		}

		// Token: 0x0601ABAD RID: 109485 RVA: 0x002761DC File Offset: 0x002743DC
		protected AKuroNvClothSelfCollisionHelperBox(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E754 RID: 59220
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroNvClothSelfCollisionHelperBox";

		// Token: 0x0400E755 RID: 59221
		private static IntPtr _ClassPtr;

		// Token: 0x0400E756 RID: 59222
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E757 RID: 59223
		internal static int __PropertyOffset_X;

		// Token: 0x0400E758 RID: 59224
		internal static int __PropertyOffset_Y;

		// Token: 0x0400E759 RID: 59225
		internal static int __PropertyOffset_Z;
	}
}
