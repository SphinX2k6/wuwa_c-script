using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020017D4 RID: 6100
	[UnrealObjectPath("/Script/KuroComputeShader.KuroCSUnifiedCollider_genericCloth_33")]
	[UnrealStructLayout(64, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FKuroCSUnifiedCollider_genericCloth_33 : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06016762 RID: 92002 RVA: 0x0020D03B File Offset: 0x0020B23B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCSUnifiedCollider_genericCloth_33._ScriptStructPtr != 0) ? FKuroCSUnifiedCollider_genericCloth_33._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComputeShader.KuroCSUnifiedCollider_genericCloth_33", ref FKuroCSUnifiedCollider_genericCloth_33._ScriptStructPtr);
		}

		// Token: 0x17005A8C RID: 23180
		// (get) Token: 0x06016763 RID: 92003 RVA: 0x0020D05F File Offset: 0x0020B25F
		// (set) Token: 0x06016764 RID: 92004 RVA: 0x0020D06F File Offset: 0x0020B26F
		public unsafe int Type
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSUnifiedCollider_genericCloth_33.__PropertyOffset_Type);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSUnifiedCollider_genericCloth_33.__PropertyOffset_Type) = value;
			}
		}

		// Token: 0x17005A8D RID: 23181
		// (get) Token: 0x06016765 RID: 92005 RVA: 0x0020D080 File Offset: 0x0020B280
		// (set) Token: 0x06016766 RID: 92006 RVA: 0x0020D094 File Offset: 0x0020B294
		public unsafe FVector Center
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSUnifiedCollider_genericCloth_33.__PropertyOffset_Center);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSUnifiedCollider_genericCloth_33.__PropertyOffset_Center) = value;
			}
		}

		// Token: 0x17005A8E RID: 23182
		// (get) Token: 0x06016767 RID: 92007 RVA: 0x0020D0A9 File Offset: 0x0020B2A9
		// (set) Token: 0x06016768 RID: 92008 RVA: 0x0020D0BD File Offset: 0x0020B2BD
		public unsafe FVector HalfSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSUnifiedCollider_genericCloth_33.__PropertyOffset_HalfSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSUnifiedCollider_genericCloth_33.__PropertyOffset_HalfSize) = value;
			}
		}

		// Token: 0x17005A8F RID: 23183
		// (get) Token: 0x06016769 RID: 92009 RVA: 0x0020D0D2 File Offset: 0x0020B2D2
		// (set) Token: 0x0601676A RID: 92010 RVA: 0x0020D0E2 File Offset: 0x0020B2E2
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSUnifiedCollider_genericCloth_33.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSUnifiedCollider_genericCloth_33.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x17005A90 RID: 23184
		// (get) Token: 0x0601676B RID: 92011 RVA: 0x0020D0F3 File Offset: 0x0020B2F3
		// (set) Token: 0x0601676C RID: 92012 RVA: 0x0020D103 File Offset: 0x0020B303
		public unsafe float Height
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSUnifiedCollider_genericCloth_33.__PropertyOffset_Height);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSUnifiedCollider_genericCloth_33.__PropertyOffset_Height) = value;
			}
		}

		// Token: 0x0601676D RID: 92013 RVA: 0x0020D114 File Offset: 0x0020B314
		public FKuroCSUnifiedCollider_genericCloth_33()
		{
		}

		// Token: 0x0601676E RID: 92014 RVA: 0x0020D11C File Offset: 0x0020B31C
		public FKuroCSUnifiedCollider_genericCloth_33(int Type, FVector Center, FVector HalfSize, float Radius, float Height)
		{
			this.Type = Type;
			this.Center = Center;
			this.HalfSize = HalfSize;
			this.Radius = Radius;
			this.Height = Height;
		}

		// Token: 0x0601676F RID: 92015 RVA: 0x0020D149 File Offset: 0x0020B349
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCSUnifiedCollider_genericCloth_33.StaticStruct();
		}

		// Token: 0x06016770 RID: 92016 RVA: 0x0020D155 File Offset: 0x0020B355
		[NullableContext(2)]
		public FKuroCSUnifiedCollider_genericCloth_33(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06016771 RID: 92017 RVA: 0x0020D15F File Offset: 0x0020B35F
		public FKuroCSUnifiedCollider_genericCloth_33(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06016772 RID: 92018 RVA: 0x0020D16A File Offset: 0x0020B36A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCSUnifiedCollider_genericCloth_33(Pointer, false, true);
		}

		// Token: 0x06016773 RID: 92019 RVA: 0x0020D174 File Offset: 0x0020B374
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCSUnifiedCollider_genericCloth_33(Pointer, MemoryOwner);
		}

		// Token: 0x0400C33E RID: 49982
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComputeShader.KuroCSUnifiedCollider_genericCloth_33";

		// Token: 0x0400C33F RID: 49983
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C340 RID: 49984
		internal static int __PropertyOffset_Type;

		// Token: 0x0400C341 RID: 49985
		internal static int __PropertyOffset_Center;

		// Token: 0x0400C342 RID: 49986
		internal static int __PropertyOffset_HalfSize;

		// Token: 0x0400C343 RID: 49987
		internal static int __PropertyOffset_Radius;

		// Token: 0x0400C344 RID: 49988
		internal static int __PropertyOffset_Height;
	}
}
