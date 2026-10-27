using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200222E RID: 8750
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkVertex")]
	[UnrealStructLayout(64, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FLiveLinkVertex : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060214F3 RID: 136435 RVA: 0x0031180D File Offset: 0x0030FA0D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLiveLinkVertex._ScriptStructPtr != 0) ? FLiveLinkVertex._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LiveLinkInterface.LiveLinkVertex", ref FLiveLinkVertex._ScriptStructPtr);
		}

		// Token: 0x170081FB RID: 33275
		// (get) Token: 0x060214F4 RID: 136436 RVA: 0x00311831 File Offset: 0x0030FA31
		// (set) Token: 0x060214F5 RID: 136437 RVA: 0x00311841 File Offset: 0x0030FA41
		public unsafe int Index
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkVertex.__PropertyOffset_Index);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkVertex.__PropertyOffset_Index) = value;
			}
		}

		// Token: 0x170081FC RID: 33276
		// (get) Token: 0x060214F6 RID: 136438 RVA: 0x00311852 File Offset: 0x0030FA52
		// (set) Token: 0x060214F7 RID: 136439 RVA: 0x00311866 File Offset: 0x0030FA66
		public unsafe FVector Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkVertex.__PropertyOffset_Position);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkVertex.__PropertyOffset_Position) = value;
			}
		}

		// Token: 0x170081FD RID: 33277
		// (get) Token: 0x060214F8 RID: 136440 RVA: 0x0031187B File Offset: 0x0030FA7B
		// (set) Token: 0x060214F9 RID: 136441 RVA: 0x0031188F File Offset: 0x0030FA8F
		public unsafe FVector Normal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkVertex.__PropertyOffset_Normal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkVertex.__PropertyOffset_Normal) = value;
			}
		}

		// Token: 0x170081FE RID: 33278
		// (get) Token: 0x060214FA RID: 136442 RVA: 0x003118A4 File Offset: 0x0030FAA4
		// (set) Token: 0x060214FB RID: 136443 RVA: 0x003118B8 File Offset: 0x0030FAB8
		public unsafe FVector Tangent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkVertex.__PropertyOffset_Tangent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkVertex.__PropertyOffset_Tangent) = value;
			}
		}

		// Token: 0x170081FF RID: 33279
		// (get) Token: 0x060214FC RID: 136444 RVA: 0x003118CD File Offset: 0x0030FACD
		// (set) Token: 0x060214FD RID: 136445 RVA: 0x003118E1 File Offset: 0x0030FAE1
		public unsafe FVector Binormal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkVertex.__PropertyOffset_Binormal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkVertex.__PropertyOffset_Binormal) = value;
			}
		}

		// Token: 0x17008200 RID: 33280
		// (get) Token: 0x060214FE RID: 136446 RVA: 0x003118F6 File Offset: 0x0030FAF6
		// (set) Token: 0x060214FF RID: 136447 RVA: 0x0031190A File Offset: 0x0030FB0A
		public unsafe FVector2D UV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkVertex.__PropertyOffset_UV);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkVertex.__PropertyOffset_UV) = value;
			}
		}

		// Token: 0x17008201 RID: 33281
		// (get) Token: 0x06021500 RID: 136448 RVA: 0x0031191F File Offset: 0x0030FB1F
		// (set) Token: 0x06021501 RID: 136449 RVA: 0x00311933 File Offset: 0x0030FB33
		public unsafe FColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkVertex.__PropertyOffset_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkVertex.__PropertyOffset_Color) = value;
			}
		}

		// Token: 0x06021502 RID: 136450 RVA: 0x00311948 File Offset: 0x0030FB48
		public FLiveLinkVertex()
		{
		}

		// Token: 0x06021503 RID: 136451 RVA: 0x00311950 File Offset: 0x0030FB50
		public FLiveLinkVertex(int Index, FVector Position, FVector Normal, FVector Tangent, FVector Binormal, FVector2D UV, FColor Color)
		{
			this.Index = Index;
			this.Position = Position;
			this.Normal = Normal;
			this.Tangent = Tangent;
			this.Binormal = Binormal;
			this.UV = UV;
			this.Color = Color;
		}

		// Token: 0x06021504 RID: 136452 RVA: 0x0031198D File Offset: 0x0030FB8D
		protected override IntPtr GetUStructPtr()
		{
			return FLiveLinkVertex.StaticStruct();
		}

		// Token: 0x06021505 RID: 136453 RVA: 0x00311999 File Offset: 0x0030FB99
		[NullableContext(2)]
		public FLiveLinkVertex(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021506 RID: 136454 RVA: 0x003119A3 File Offset: 0x0030FBA3
		public FLiveLinkVertex(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021507 RID: 136455 RVA: 0x003119AE File Offset: 0x0030FBAE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLiveLinkVertex(Pointer, false, true);
		}

		// Token: 0x06021508 RID: 136456 RVA: 0x003119B8 File Offset: 0x0030FBB8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLiveLinkVertex(Pointer, MemoryOwner);
		}

		// Token: 0x04011C31 RID: 72753
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkVertex";

		// Token: 0x04011C32 RID: 72754
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011C33 RID: 72755
		internal static int __PropertyOffset_Index;

		// Token: 0x04011C34 RID: 72756
		internal static int __PropertyOffset_Position;

		// Token: 0x04011C35 RID: 72757
		internal static int __PropertyOffset_Normal;

		// Token: 0x04011C36 RID: 72758
		internal static int __PropertyOffset_Tangent;

		// Token: 0x04011C37 RID: 72759
		internal static int __PropertyOffset_Binormal;

		// Token: 0x04011C38 RID: 72760
		internal static int __PropertyOffset_UV;

		// Token: 0x04011C39 RID: 72761
		internal static int __PropertyOffset_Color;
	}
}
