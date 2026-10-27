using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001790 RID: 6032
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroComputeShader.JacobiChainRenderVertex")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FJacobiChainRenderVertex : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06015B78 RID: 88952 RVA: 0x001FE9F5 File Offset: 0x001FCBF5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FJacobiChainRenderVertex._ScriptStructPtr != 0) ? FJacobiChainRenderVertex._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComputeShader.JacobiChainRenderVertex", ref FJacobiChainRenderVertex._ScriptStructPtr);
		}

		// Token: 0x170055EB RID: 21995
		// (get) Token: 0x06015B79 RID: 88953 RVA: 0x001FEA19 File Offset: 0x001FCC19
		// (set) Token: 0x06015B7A RID: 88954 RVA: 0x001FEA2D File Offset: 0x001FCC2D
		public unsafe FVector Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainRenderVertex.__PropertyOffset_Position);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainRenderVertex.__PropertyOffset_Position) = value;
			}
		}

		// Token: 0x170055EC RID: 21996
		// (get) Token: 0x06015B7B RID: 88955 RVA: 0x001FEA42 File Offset: 0x001FCC42
		// (set) Token: 0x06015B7C RID: 88956 RVA: 0x001FEA56 File Offset: 0x001FCC56
		public unsafe FVector TangentX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainRenderVertex.__PropertyOffset_TangentX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainRenderVertex.__PropertyOffset_TangentX) = value;
			}
		}

		// Token: 0x170055ED RID: 21997
		// (get) Token: 0x06015B7D RID: 88957 RVA: 0x001FEA6B File Offset: 0x001FCC6B
		// (set) Token: 0x06015B7E RID: 88958 RVA: 0x001FEA7F File Offset: 0x001FCC7F
		public unsafe FVector TangentY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainRenderVertex.__PropertyOffset_TangentY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainRenderVertex.__PropertyOffset_TangentY) = value;
			}
		}

		// Token: 0x170055EE RID: 21998
		// (get) Token: 0x06015B7F RID: 88959 RVA: 0x001FEA94 File Offset: 0x001FCC94
		// (set) Token: 0x06015B80 RID: 88960 RVA: 0x001FEAA8 File Offset: 0x001FCCA8
		public unsafe FVector Normal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainRenderVertex.__PropertyOffset_Normal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainRenderVertex.__PropertyOffset_Normal) = value;
			}
		}

		// Token: 0x170055EF RID: 21999
		// (get) Token: 0x06015B81 RID: 88961 RVA: 0x001FEAC0 File Offset: 0x001FCCC0
		// (set) Token: 0x06015B82 RID: 88962 RVA: 0x001FEB03 File Offset: 0x001FCD03
		public TArray<FVector2D> UVs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector2D> result;
				if ((result = this._UVs) == null)
				{
					result = (this._UVs = new TArray<FVector2D>(base.NativePtr + (IntPtr)FJacobiChainRenderVertex.__PropertyOffset_UVs, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.UVs.CopyAssign(value);
			}
		}

		// Token: 0x170055F0 RID: 22000
		// (get) Token: 0x06015B83 RID: 88963 RVA: 0x001FEB11 File Offset: 0x001FCD11
		// (set) Token: 0x06015B84 RID: 88964 RVA: 0x001FEB25 File Offset: 0x001FCD25
		public unsafe FColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainRenderVertex.__PropertyOffset_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainRenderVertex.__PropertyOffset_Color) = value;
			}
		}

		// Token: 0x06015B85 RID: 88965 RVA: 0x001FEB3A File Offset: 0x001FCD3A
		public FJacobiChainRenderVertex()
		{
		}

		// Token: 0x06015B86 RID: 88966 RVA: 0x001FEB42 File Offset: 0x001FCD42
		public FJacobiChainRenderVertex(FVector Position, FVector TangentX, FVector TangentY, FVector Normal, TArray<FVector2D> UVs, FColor Color)
		{
			this.Position = Position;
			this.TangentX = TangentX;
			this.TangentY = TangentY;
			this.Normal = Normal;
			this.UVs = UVs;
			this.Color = Color;
		}

		// Token: 0x06015B87 RID: 88967 RVA: 0x001FEB77 File Offset: 0x001FCD77
		protected override IntPtr GetUStructPtr()
		{
			return FJacobiChainRenderVertex.StaticStruct();
		}

		// Token: 0x06015B88 RID: 88968 RVA: 0x001FEB83 File Offset: 0x001FCD83
		[NullableContext(2)]
		public FJacobiChainRenderVertex(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06015B89 RID: 88969 RVA: 0x001FEB8D File Offset: 0x001FCD8D
		public FJacobiChainRenderVertex(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06015B8A RID: 88970 RVA: 0x001FEB98 File Offset: 0x001FCD98
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FJacobiChainRenderVertex(Pointer, false, true);
		}

		// Token: 0x06015B8B RID: 88971 RVA: 0x001FEBA2 File Offset: 0x001FCDA2
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FJacobiChainRenderVertex(Pointer, MemoryOwner);
		}

		// Token: 0x0400BDB2 RID: 48562
		public const string __ObjectPath = "/Script/KuroComputeShader.JacobiChainRenderVertex";

		// Token: 0x0400BDB3 RID: 48563
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400BDB4 RID: 48564
		internal static int __PropertyOffset_Position;

		// Token: 0x0400BDB5 RID: 48565
		internal static int __PropertyOffset_TangentX;

		// Token: 0x0400BDB6 RID: 48566
		internal static int __PropertyOffset_TangentY;

		// Token: 0x0400BDB7 RID: 48567
		internal static int __PropertyOffset_Normal;

		// Token: 0x0400BDB8 RID: 48568
		internal static int __PropertyOffset_UVs;

		// Token: 0x0400BDB9 RID: 48569
		[Nullable(2)]
		private TArray<FVector2D> _UVs;

		// Token: 0x0400BDBA RID: 48570
		internal static int __PropertyOffset_Color;
	}
}
