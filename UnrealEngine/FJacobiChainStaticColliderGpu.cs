using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001794 RID: 6036
	[UnrealObjectPath("/Script/KuroComputeShader.JacobiChainStaticColliderGpu")]
	[UnrealStructLayout(64, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FJacobiChainStaticColliderGpu : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06015BCE RID: 89038 RVA: 0x001FF08C File Offset: 0x001FD28C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FJacobiChainStaticColliderGpu._ScriptStructPtr != 0) ? FJacobiChainStaticColliderGpu._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComputeShader.JacobiChainStaticColliderGpu", ref FJacobiChainStaticColliderGpu._ScriptStructPtr);
		}

		// Token: 0x17005606 RID: 22022
		// (get) Token: 0x06015BCF RID: 89039 RVA: 0x001FF0B0 File Offset: 0x001FD2B0
		// (set) Token: 0x06015BD0 RID: 89040 RVA: 0x001FF0C0 File Offset: 0x001FD2C0
		public unsafe int Type
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainStaticColliderGpu.__PropertyOffset_Type);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainStaticColliderGpu.__PropertyOffset_Type) = value;
			}
		}

		// Token: 0x17005607 RID: 22023
		// (get) Token: 0x06015BD1 RID: 89041 RVA: 0x001FF0D1 File Offset: 0x001FD2D1
		// (set) Token: 0x06015BD2 RID: 89042 RVA: 0x001FF0E5 File Offset: 0x001FD2E5
		public unsafe FVector Center
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainStaticColliderGpu.__PropertyOffset_Center);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainStaticColliderGpu.__PropertyOffset_Center) = value;
			}
		}

		// Token: 0x17005608 RID: 22024
		// (get) Token: 0x06015BD3 RID: 89043 RVA: 0x001FF0FA File Offset: 0x001FD2FA
		// (set) Token: 0x06015BD4 RID: 89044 RVA: 0x001FF10E File Offset: 0x001FD30E
		public unsafe FVector Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainStaticColliderGpu.__PropertyOffset_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainStaticColliderGpu.__PropertyOffset_Rotation) = value;
			}
		}

		// Token: 0x17005609 RID: 22025
		// (get) Token: 0x06015BD5 RID: 89045 RVA: 0x001FF123 File Offset: 0x001FD323
		// (set) Token: 0x06015BD6 RID: 89046 RVA: 0x001FF133 File Offset: 0x001FD333
		public unsafe float Padding0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainStaticColliderGpu.__PropertyOffset_Padding0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainStaticColliderGpu.__PropertyOffset_Padding0) = value;
			}
		}

		// Token: 0x1700560A RID: 22026
		// (get) Token: 0x06015BD7 RID: 89047 RVA: 0x001FF144 File Offset: 0x001FD344
		// (set) Token: 0x06015BD8 RID: 89048 RVA: 0x001FF158 File Offset: 0x001FD358
		public unsafe FVector HalfSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainStaticColliderGpu.__PropertyOffset_HalfSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainStaticColliderGpu.__PropertyOffset_HalfSize) = value;
			}
		}

		// Token: 0x1700560B RID: 22027
		// (get) Token: 0x06015BD9 RID: 89049 RVA: 0x001FF16D File Offset: 0x001FD36D
		// (set) Token: 0x06015BDA RID: 89050 RVA: 0x001FF17D File Offset: 0x001FD37D
		public unsafe float Padding1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainStaticColliderGpu.__PropertyOffset_Padding1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainStaticColliderGpu.__PropertyOffset_Padding1) = value;
			}
		}

		// Token: 0x1700560C RID: 22028
		// (get) Token: 0x06015BDB RID: 89051 RVA: 0x001FF18E File Offset: 0x001FD38E
		// (set) Token: 0x06015BDC RID: 89052 RVA: 0x001FF1A2 File Offset: 0x001FD3A2
		public unsafe FVector4 Padding2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainStaticColliderGpu.__PropertyOffset_Padding2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainStaticColliderGpu.__PropertyOffset_Padding2) = value;
			}
		}

		// Token: 0x06015BDD RID: 89053 RVA: 0x001FF1B7 File Offset: 0x001FD3B7
		public FJacobiChainStaticColliderGpu()
		{
		}

		// Token: 0x06015BDE RID: 89054 RVA: 0x001FF1BF File Offset: 0x001FD3BF
		public FJacobiChainStaticColliderGpu(int Type, FVector Center, FVector Rotation, float Padding0, FVector HalfSize, float Padding1, FVector4 Padding2)
		{
			this.Type = Type;
			this.Center = Center;
			this.Rotation = Rotation;
			this.Padding0 = Padding0;
			this.HalfSize = HalfSize;
			this.Padding1 = Padding1;
			this.Padding2 = Padding2;
		}

		// Token: 0x06015BDF RID: 89055 RVA: 0x001FF1FC File Offset: 0x001FD3FC
		protected override IntPtr GetUStructPtr()
		{
			return FJacobiChainStaticColliderGpu.StaticStruct();
		}

		// Token: 0x06015BE0 RID: 89056 RVA: 0x001FF208 File Offset: 0x001FD408
		[NullableContext(2)]
		public FJacobiChainStaticColliderGpu(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06015BE1 RID: 89057 RVA: 0x001FF212 File Offset: 0x001FD412
		public FJacobiChainStaticColliderGpu(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06015BE2 RID: 89058 RVA: 0x001FF21D File Offset: 0x001FD41D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FJacobiChainStaticColliderGpu(Pointer, false, true);
		}

		// Token: 0x06015BE3 RID: 89059 RVA: 0x001FF227 File Offset: 0x001FD427
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FJacobiChainStaticColliderGpu(Pointer, MemoryOwner);
		}

		// Token: 0x0400BDD6 RID: 48598
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComputeShader.JacobiChainStaticColliderGpu";

		// Token: 0x0400BDD7 RID: 48599
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400BDD8 RID: 48600
		internal static int __PropertyOffset_Type;

		// Token: 0x0400BDD9 RID: 48601
		internal static int __PropertyOffset_Center;

		// Token: 0x0400BDDA RID: 48602
		internal static int __PropertyOffset_Rotation;

		// Token: 0x0400BDDB RID: 48603
		internal static int __PropertyOffset_Padding0;

		// Token: 0x0400BDDC RID: 48604
		internal static int __PropertyOffset_HalfSize;

		// Token: 0x0400BDDD RID: 48605
		internal static int __PropertyOffset_Padding1;

		// Token: 0x0400BDDE RID: 48606
		internal static int __PropertyOffset_Padding2;
	}
}
