using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020017D3 RID: 6099
	[UnrealObjectPath("/Script/KuroComputeShader.KuroCSUnifiedCollider_genericCloth")]
	[UnrealStructLayout(64, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FKuroCSUnifiedCollider_genericCloth : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06016750 RID: 91984 RVA: 0x0020CEF9 File Offset: 0x0020B0F9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCSUnifiedCollider_genericCloth._ScriptStructPtr != 0) ? FKuroCSUnifiedCollider_genericCloth._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComputeShader.KuroCSUnifiedCollider_genericCloth", ref FKuroCSUnifiedCollider_genericCloth._ScriptStructPtr);
		}

		// Token: 0x17005A87 RID: 23175
		// (get) Token: 0x06016751 RID: 91985 RVA: 0x0020CF1D File Offset: 0x0020B11D
		// (set) Token: 0x06016752 RID: 91986 RVA: 0x0020CF2D File Offset: 0x0020B12D
		public unsafe int Type
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSUnifiedCollider_genericCloth.__PropertyOffset_Type);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSUnifiedCollider_genericCloth.__PropertyOffset_Type) = value;
			}
		}

		// Token: 0x17005A88 RID: 23176
		// (get) Token: 0x06016753 RID: 91987 RVA: 0x0020CF3E File Offset: 0x0020B13E
		// (set) Token: 0x06016754 RID: 91988 RVA: 0x0020CF52 File Offset: 0x0020B152
		public unsafe FVector Center
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSUnifiedCollider_genericCloth.__PropertyOffset_Center);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSUnifiedCollider_genericCloth.__PropertyOffset_Center) = value;
			}
		}

		// Token: 0x17005A89 RID: 23177
		// (get) Token: 0x06016755 RID: 91989 RVA: 0x0020CF67 File Offset: 0x0020B167
		// (set) Token: 0x06016756 RID: 91990 RVA: 0x0020CF7B File Offset: 0x0020B17B
		public unsafe FVector HalfSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSUnifiedCollider_genericCloth.__PropertyOffset_HalfSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSUnifiedCollider_genericCloth.__PropertyOffset_HalfSize) = value;
			}
		}

		// Token: 0x17005A8A RID: 23178
		// (get) Token: 0x06016757 RID: 91991 RVA: 0x0020CF90 File Offset: 0x0020B190
		// (set) Token: 0x06016758 RID: 91992 RVA: 0x0020CFA0 File Offset: 0x0020B1A0
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSUnifiedCollider_genericCloth.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSUnifiedCollider_genericCloth.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x17005A8B RID: 23179
		// (get) Token: 0x06016759 RID: 91993 RVA: 0x0020CFB1 File Offset: 0x0020B1B1
		// (set) Token: 0x0601675A RID: 91994 RVA: 0x0020CFC1 File Offset: 0x0020B1C1
		public unsafe float Height
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSUnifiedCollider_genericCloth.__PropertyOffset_Height);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSUnifiedCollider_genericCloth.__PropertyOffset_Height) = value;
			}
		}

		// Token: 0x0601675B RID: 91995 RVA: 0x0020CFD2 File Offset: 0x0020B1D2
		public FKuroCSUnifiedCollider_genericCloth()
		{
		}

		// Token: 0x0601675C RID: 91996 RVA: 0x0020CFDA File Offset: 0x0020B1DA
		public FKuroCSUnifiedCollider_genericCloth(int Type, FVector Center, FVector HalfSize, float Radius, float Height)
		{
			this.Type = Type;
			this.Center = Center;
			this.HalfSize = HalfSize;
			this.Radius = Radius;
			this.Height = Height;
		}

		// Token: 0x0601675D RID: 91997 RVA: 0x0020D007 File Offset: 0x0020B207
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCSUnifiedCollider_genericCloth.StaticStruct();
		}

		// Token: 0x0601675E RID: 91998 RVA: 0x0020D013 File Offset: 0x0020B213
		[NullableContext(2)]
		public FKuroCSUnifiedCollider_genericCloth(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601675F RID: 91999 RVA: 0x0020D01D File Offset: 0x0020B21D
		public FKuroCSUnifiedCollider_genericCloth(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06016760 RID: 92000 RVA: 0x0020D028 File Offset: 0x0020B228
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCSUnifiedCollider_genericCloth(Pointer, false, true);
		}

		// Token: 0x06016761 RID: 92001 RVA: 0x0020D032 File Offset: 0x0020B232
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCSUnifiedCollider_genericCloth(Pointer, MemoryOwner);
		}

		// Token: 0x0400C337 RID: 49975
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComputeShader.KuroCSUnifiedCollider_genericCloth";

		// Token: 0x0400C338 RID: 49976
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C339 RID: 49977
		internal static int __PropertyOffset_Type;

		// Token: 0x0400C33A RID: 49978
		internal static int __PropertyOffset_Center;

		// Token: 0x0400C33B RID: 49979
		internal static int __PropertyOffset_HalfSize;

		// Token: 0x0400C33C RID: 49980
		internal static int __PropertyOffset_Radius;

		// Token: 0x0400C33D RID: 49981
		internal static int __PropertyOffset_Height;
	}
}
