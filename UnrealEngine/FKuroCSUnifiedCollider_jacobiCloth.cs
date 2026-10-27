using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020017D5 RID: 6101
	[UnrealObjectPath("/Script/KuroComputeShader.KuroCSUnifiedCollider_jacobiCloth")]
	[UnrealStructLayout(64, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FKuroCSUnifiedCollider_jacobiCloth : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06016774 RID: 92020 RVA: 0x0020D17D File Offset: 0x0020B37D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCSUnifiedCollider_jacobiCloth._ScriptStructPtr != 0) ? FKuroCSUnifiedCollider_jacobiCloth._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComputeShader.KuroCSUnifiedCollider_jacobiCloth", ref FKuroCSUnifiedCollider_jacobiCloth._ScriptStructPtr);
		}

		// Token: 0x17005A91 RID: 23185
		// (get) Token: 0x06016775 RID: 92021 RVA: 0x0020D1A1 File Offset: 0x0020B3A1
		// (set) Token: 0x06016776 RID: 92022 RVA: 0x0020D1B1 File Offset: 0x0020B3B1
		public unsafe int Type
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSUnifiedCollider_jacobiCloth.__PropertyOffset_Type);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSUnifiedCollider_jacobiCloth.__PropertyOffset_Type) = value;
			}
		}

		// Token: 0x17005A92 RID: 23186
		// (get) Token: 0x06016777 RID: 92023 RVA: 0x0020D1C2 File Offset: 0x0020B3C2
		// (set) Token: 0x06016778 RID: 92024 RVA: 0x0020D1D6 File Offset: 0x0020B3D6
		public unsafe FVector Center
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSUnifiedCollider_jacobiCloth.__PropertyOffset_Center);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSUnifiedCollider_jacobiCloth.__PropertyOffset_Center) = value;
			}
		}

		// Token: 0x17005A93 RID: 23187
		// (get) Token: 0x06016779 RID: 92025 RVA: 0x0020D1EB File Offset: 0x0020B3EB
		// (set) Token: 0x0601677A RID: 92026 RVA: 0x0020D1FF File Offset: 0x0020B3FF
		public unsafe FVector Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSUnifiedCollider_jacobiCloth.__PropertyOffset_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSUnifiedCollider_jacobiCloth.__PropertyOffset_Rotation) = value;
			}
		}

		// Token: 0x17005A94 RID: 23188
		// (get) Token: 0x0601677B RID: 92027 RVA: 0x0020D214 File Offset: 0x0020B414
		// (set) Token: 0x0601677C RID: 92028 RVA: 0x0020D228 File Offset: 0x0020B428
		public unsafe FVector HalfSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSUnifiedCollider_jacobiCloth.__PropertyOffset_HalfSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSUnifiedCollider_jacobiCloth.__PropertyOffset_HalfSize) = value;
			}
		}

		// Token: 0x17005A95 RID: 23189
		// (get) Token: 0x0601677D RID: 92029 RVA: 0x0020D23D File Offset: 0x0020B43D
		// (set) Token: 0x0601677E RID: 92030 RVA: 0x0020D24D File Offset: 0x0020B44D
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSUnifiedCollider_jacobiCloth.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSUnifiedCollider_jacobiCloth.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x17005A96 RID: 23190
		// (get) Token: 0x0601677F RID: 92031 RVA: 0x0020D25E File Offset: 0x0020B45E
		// (set) Token: 0x06016780 RID: 92032 RVA: 0x0020D26E File Offset: 0x0020B46E
		public unsafe float Height
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCSUnifiedCollider_jacobiCloth.__PropertyOffset_Height);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCSUnifiedCollider_jacobiCloth.__PropertyOffset_Height) = value;
			}
		}

		// Token: 0x06016781 RID: 92033 RVA: 0x0020D27F File Offset: 0x0020B47F
		public FKuroCSUnifiedCollider_jacobiCloth()
		{
		}

		// Token: 0x06016782 RID: 92034 RVA: 0x0020D287 File Offset: 0x0020B487
		public FKuroCSUnifiedCollider_jacobiCloth(int Type, FVector Center, FVector Rotation, FVector HalfSize, float Radius, float Height)
		{
			this.Type = Type;
			this.Center = Center;
			this.Rotation = Rotation;
			this.HalfSize = HalfSize;
			this.Radius = Radius;
			this.Height = Height;
		}

		// Token: 0x06016783 RID: 92035 RVA: 0x0020D2BC File Offset: 0x0020B4BC
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCSUnifiedCollider_jacobiCloth.StaticStruct();
		}

		// Token: 0x06016784 RID: 92036 RVA: 0x0020D2C8 File Offset: 0x0020B4C8
		[NullableContext(2)]
		public FKuroCSUnifiedCollider_jacobiCloth(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06016785 RID: 92037 RVA: 0x0020D2D2 File Offset: 0x0020B4D2
		public FKuroCSUnifiedCollider_jacobiCloth(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06016786 RID: 92038 RVA: 0x0020D2DD File Offset: 0x0020B4DD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCSUnifiedCollider_jacobiCloth(Pointer, false, true);
		}

		// Token: 0x06016787 RID: 92039 RVA: 0x0020D2E7 File Offset: 0x0020B4E7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCSUnifiedCollider_jacobiCloth(Pointer, MemoryOwner);
		}

		// Token: 0x0400C345 RID: 49989
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComputeShader.KuroCSUnifiedCollider_jacobiCloth";

		// Token: 0x0400C346 RID: 49990
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C347 RID: 49991
		internal static int __PropertyOffset_Type;

		// Token: 0x0400C348 RID: 49992
		internal static int __PropertyOffset_Center;

		// Token: 0x0400C349 RID: 49993
		internal static int __PropertyOffset_Rotation;

		// Token: 0x0400C34A RID: 49994
		internal static int __PropertyOffset_HalfSize;

		// Token: 0x0400C34B RID: 49995
		internal static int __PropertyOffset_Radius;

		// Token: 0x0400C34C RID: 49996
		internal static int __PropertyOffset_Height;
	}
}
