using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001A63 RID: 6755
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.CoralSphere")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FCoralSphere : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601901D RID: 102429 RVA: 0x0024F58A File Offset: 0x0024D78A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCoralSphere._ScriptStructPtr != 0) ? FCoralSphere._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.CoralSphere", ref FCoralSphere._ScriptStructPtr);
		}

		// Token: 0x17006322 RID: 25378
		// (get) Token: 0x0601901E RID: 102430 RVA: 0x0024F5AE File Offset: 0x0024D7AE
		// (set) Token: 0x0601901F RID: 102431 RVA: 0x0024F5C2 File Offset: 0x0024D7C2
		public unsafe FVectorDouble Center
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCoralSphere.__PropertyOffset_Center);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCoralSphere.__PropertyOffset_Center) = value;
			}
		}

		// Token: 0x17006323 RID: 25379
		// (get) Token: 0x06019020 RID: 102432 RVA: 0x0024F5D7 File Offset: 0x0024D7D7
		// (set) Token: 0x06019021 RID: 102433 RVA: 0x0024F5E7 File Offset: 0x0024D7E7
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCoralSphere.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCoralSphere.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x17006324 RID: 25380
		// (get) Token: 0x06019022 RID: 102434 RVA: 0x0024F5F8 File Offset: 0x0024D7F8
		// (set) Token: 0x06019023 RID: 102435 RVA: 0x0024F608 File Offset: 0x0024D808
		public unsafe float Strength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCoralSphere.__PropertyOffset_Strength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCoralSphere.__PropertyOffset_Strength) = value;
			}
		}

		// Token: 0x06019024 RID: 102436 RVA: 0x0024F619 File Offset: 0x0024D819
		public FCoralSphere()
		{
		}

		// Token: 0x06019025 RID: 102437 RVA: 0x0024F621 File Offset: 0x0024D821
		public FCoralSphere(FVectorDouble Center, float Radius, float Strength)
		{
			this.Center = Center;
			this.Radius = Radius;
			this.Strength = Strength;
		}

		// Token: 0x06019026 RID: 102438 RVA: 0x0024F63E File Offset: 0x0024D83E
		protected override IntPtr GetUStructPtr()
		{
			return FCoralSphere.StaticStruct();
		}

		// Token: 0x06019027 RID: 102439 RVA: 0x0024F64A File Offset: 0x0024D84A
		[NullableContext(2)]
		public FCoralSphere(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06019028 RID: 102440 RVA: 0x0024F654 File Offset: 0x0024D854
		public FCoralSphere(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06019029 RID: 102441 RVA: 0x0024F65F File Offset: 0x0024D85F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCoralSphere(Pointer, false, true);
		}

		// Token: 0x0601902A RID: 102442 RVA: 0x0024F669 File Offset: 0x0024D869
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCoralSphere(Pointer, MemoryOwner);
		}

		// Token: 0x0400D873 RID: 55411
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.CoralSphere";

		// Token: 0x0400D874 RID: 55412
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400D875 RID: 55413
		internal static int __PropertyOffset_Center;

		// Token: 0x0400D876 RID: 55414
		internal static int __PropertyOffset_Radius;

		// Token: 0x0400D877 RID: 55415
		internal static int __PropertyOffset_Strength;
	}
}
