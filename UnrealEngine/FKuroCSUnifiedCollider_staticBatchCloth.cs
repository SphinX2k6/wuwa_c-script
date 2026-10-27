using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020017D6 RID: 6102
	[UnrealObjectPath("/Script/KuroComputeShader.KuroCSUnifiedCollider_staticBatchCloth")]
	[UnrealStructLayout(64, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FKuroCSUnifiedCollider_staticBatchCloth : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06016788 RID: 92040 RVA: 0x0020D2F0 File Offset: 0x0020B4F0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCSUnifiedCollider_staticBatchCloth._ScriptStructPtr != 0) ? FKuroCSUnifiedCollider_staticBatchCloth._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComputeShader.KuroCSUnifiedCollider_staticBatchCloth", ref FKuroCSUnifiedCollider_staticBatchCloth._ScriptStructPtr);
		}

		// Token: 0x17005A97 RID: 23191
		// (get) Token: 0x06016789 RID: 92041 RVA: 0x0020D314 File Offset: 0x0020B514
		// (set) Token: 0x0601678A RID: 92042 RVA: 0x0020D324 File Offset: 0x0020B524
		public unsafe int Type
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSUnifiedCollider_staticBatchCloth.__PropertyOffset_Type);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSUnifiedCollider_staticBatchCloth.__PropertyOffset_Type) = value;
			}
		}

		// Token: 0x17005A98 RID: 23192
		// (get) Token: 0x0601678B RID: 92043 RVA: 0x0020D335 File Offset: 0x0020B535
		// (set) Token: 0x0601678C RID: 92044 RVA: 0x0020D349 File Offset: 0x0020B549
		public unsafe FVector Center
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSUnifiedCollider_staticBatchCloth.__PropertyOffset_Center);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSUnifiedCollider_staticBatchCloth.__PropertyOffset_Center) = value;
			}
		}

		// Token: 0x17005A99 RID: 23193
		// (get) Token: 0x0601678D RID: 92045 RVA: 0x0020D35E File Offset: 0x0020B55E
		// (set) Token: 0x0601678E RID: 92046 RVA: 0x0020D372 File Offset: 0x0020B572
		public unsafe FVector Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSUnifiedCollider_staticBatchCloth.__PropertyOffset_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSUnifiedCollider_staticBatchCloth.__PropertyOffset_Rotation) = value;
			}
		}

		// Token: 0x17005A9A RID: 23194
		// (get) Token: 0x0601678F RID: 92047 RVA: 0x0020D387 File Offset: 0x0020B587
		// (set) Token: 0x06016790 RID: 92048 RVA: 0x0020D39B File Offset: 0x0020B59B
		public unsafe FVector HalfSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSUnifiedCollider_staticBatchCloth.__PropertyOffset_HalfSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSUnifiedCollider_staticBatchCloth.__PropertyOffset_HalfSize) = value;
			}
		}

		// Token: 0x17005A9B RID: 23195
		// (get) Token: 0x06016791 RID: 92049 RVA: 0x0020D3B0 File Offset: 0x0020B5B0
		// (set) Token: 0x06016792 RID: 92050 RVA: 0x0020D3C0 File Offset: 0x0020B5C0
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSUnifiedCollider_staticBatchCloth.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSUnifiedCollider_staticBatchCloth.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x17005A9C RID: 23196
		// (get) Token: 0x06016793 RID: 92051 RVA: 0x0020D3D1 File Offset: 0x0020B5D1
		// (set) Token: 0x06016794 RID: 92052 RVA: 0x0020D3E1 File Offset: 0x0020B5E1
		public unsafe float Height
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSUnifiedCollider_staticBatchCloth.__PropertyOffset_Height);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSUnifiedCollider_staticBatchCloth.__PropertyOffset_Height) = value;
			}
		}

		// Token: 0x06016795 RID: 92053 RVA: 0x0020D3F2 File Offset: 0x0020B5F2
		public FKuroCSUnifiedCollider_staticBatchCloth()
		{
		}

		// Token: 0x06016796 RID: 92054 RVA: 0x0020D3FA File Offset: 0x0020B5FA
		public FKuroCSUnifiedCollider_staticBatchCloth(int Type, FVector Center, FVector Rotation, FVector HalfSize, float Radius, float Height)
		{
			this.Type = Type;
			this.Center = Center;
			this.Rotation = Rotation;
			this.HalfSize = HalfSize;
			this.Radius = Radius;
			this.Height = Height;
		}

		// Token: 0x06016797 RID: 92055 RVA: 0x0020D42F File Offset: 0x0020B62F
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCSUnifiedCollider_staticBatchCloth.StaticStruct();
		}

		// Token: 0x06016798 RID: 92056 RVA: 0x0020D43B File Offset: 0x0020B63B
		[NullableContext(2)]
		public FKuroCSUnifiedCollider_staticBatchCloth(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06016799 RID: 92057 RVA: 0x0020D445 File Offset: 0x0020B645
		public FKuroCSUnifiedCollider_staticBatchCloth(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601679A RID: 92058 RVA: 0x0020D450 File Offset: 0x0020B650
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCSUnifiedCollider_staticBatchCloth(Pointer, false, true);
		}

		// Token: 0x0601679B RID: 92059 RVA: 0x0020D45A File Offset: 0x0020B65A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCSUnifiedCollider_staticBatchCloth(Pointer, MemoryOwner);
		}

		// Token: 0x0400C34D RID: 49997
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComputeShader.KuroCSUnifiedCollider_staticBatchCloth";

		// Token: 0x0400C34E RID: 49998
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C34F RID: 49999
		internal static int __PropertyOffset_Type;

		// Token: 0x0400C350 RID: 50000
		internal static int __PropertyOffset_Center;

		// Token: 0x0400C351 RID: 50001
		internal static int __PropertyOffset_Rotation;

		// Token: 0x0400C352 RID: 50002
		internal static int __PropertyOffset_HalfSize;

		// Token: 0x0400C353 RID: 50003
		internal static int __PropertyOffset_Radius;

		// Token: 0x0400C354 RID: 50004
		internal static int __PropertyOffset_Height;
	}
}
