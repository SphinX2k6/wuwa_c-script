using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200265D RID: 9821
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ProceduralMeshComponent.ProcMeshSection")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FProcMeshSection : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602480A RID: 149514 RVA: 0x00360BCA File Offset: 0x0035EDCA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FProcMeshSection._ScriptStructPtr != 0) ? FProcMeshSection._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ProceduralMeshComponent.ProcMeshSection", ref FProcMeshSection._ScriptStructPtr);
		}

		// Token: 0x17008CAC RID: 36012
		// (get) Token: 0x0602480B RID: 149515 RVA: 0x00360BF0 File Offset: 0x0035EDF0
		// (set) Token: 0x0602480C RID: 149516 RVA: 0x00360C33 File Offset: 0x0035EE33
		public TArray<FProcMeshVertex> ProcVertexBuffer
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FProcMeshVertex> result;
				if ((result = this._ProcVertexBuffer) == null)
				{
					result = (this._ProcVertexBuffer = new TArray<FProcMeshVertex>(base.NativePtr + (IntPtr)FProcMeshSection.__PropertyOffset_ProcVertexBuffer, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ProcVertexBuffer.CopyAssign(value);
			}
		}

		// Token: 0x17008CAD RID: 36013
		// (get) Token: 0x0602480D RID: 149517 RVA: 0x00360C44 File Offset: 0x0035EE44
		// (set) Token: 0x0602480E RID: 149518 RVA: 0x00360C87 File Offset: 0x0035EE87
		public TArray<uint> ProcIndexBuffer
		{
			get
			{
				base.FastCheckIsValid();
				TArray<uint> result;
				if ((result = this._ProcIndexBuffer) == null)
				{
					result = (this._ProcIndexBuffer = new TArray<uint>(base.NativePtr + (IntPtr)FProcMeshSection.__PropertyOffset_ProcIndexBuffer, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ProcIndexBuffer.CopyAssign(value);
			}
		}

		// Token: 0x17008CAE RID: 36014
		// (get) Token: 0x0602480F RID: 149519 RVA: 0x00360C95 File Offset: 0x0035EE95
		// (set) Token: 0x06024810 RID: 149520 RVA: 0x00360CA9 File Offset: 0x0035EEA9
		public unsafe FBox SectionLocalBox
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FProcMeshSection.__PropertyOffset_SectionLocalBox);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FProcMeshSection.__PropertyOffset_SectionLocalBox) = value;
			}
		}

		// Token: 0x17008CAF RID: 36015
		// (get) Token: 0x06024811 RID: 149521 RVA: 0x00360CBE File Offset: 0x0035EEBE
		// (set) Token: 0x06024812 RID: 149522 RVA: 0x00360CCE File Offset: 0x0035EECE
		public unsafe bool bEnableCollision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FProcMeshSection.__PropertyOffset_bEnableCollision) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FProcMeshSection.__PropertyOffset_bEnableCollision) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008CB0 RID: 36016
		// (get) Token: 0x06024813 RID: 149523 RVA: 0x00360CDF File Offset: 0x0035EEDF
		// (set) Token: 0x06024814 RID: 149524 RVA: 0x00360CEF File Offset: 0x0035EEEF
		public unsafe bool bSectionVisible
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FProcMeshSection.__PropertyOffset_bSectionVisible) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FProcMeshSection.__PropertyOffset_bSectionVisible) = (value ? 1 : 0);
			}
		}

		// Token: 0x06024815 RID: 149525 RVA: 0x00360D00 File Offset: 0x0035EF00
		public FProcMeshSection()
		{
		}

		// Token: 0x06024816 RID: 149526 RVA: 0x00360D08 File Offset: 0x0035EF08
		public FProcMeshSection(TArray<FProcMeshVertex> ProcVertexBuffer, TArray<uint> ProcIndexBuffer, FBox SectionLocalBox, bool bEnableCollision, bool bSectionVisible)
		{
			this.ProcVertexBuffer = ProcVertexBuffer;
			this.ProcIndexBuffer = ProcIndexBuffer;
			this.SectionLocalBox = SectionLocalBox;
			this.bEnableCollision = bEnableCollision;
			this.bSectionVisible = bSectionVisible;
		}

		// Token: 0x06024817 RID: 149527 RVA: 0x00360D35 File Offset: 0x0035EF35
		protected override IntPtr GetUStructPtr()
		{
			return FProcMeshSection.StaticStruct();
		}

		// Token: 0x06024818 RID: 149528 RVA: 0x00360D41 File Offset: 0x0035EF41
		[NullableContext(2)]
		public FProcMeshSection(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024819 RID: 149529 RVA: 0x00360D4B File Offset: 0x0035EF4B
		public FProcMeshSection(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602481A RID: 149530 RVA: 0x00360D56 File Offset: 0x0035EF56
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FProcMeshSection(Pointer, false, true);
		}

		// Token: 0x0602481B RID: 149531 RVA: 0x00360D60 File Offset: 0x0035EF60
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FProcMeshSection(Pointer, MemoryOwner);
		}

		// Token: 0x040139B9 RID: 80313
		public const string __ObjectPath = "/Script/ProceduralMeshComponent.ProcMeshSection";

		// Token: 0x040139BA RID: 80314
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040139BB RID: 80315
		internal static int __PropertyOffset_ProcVertexBuffer;

		// Token: 0x040139BC RID: 80316
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FProcMeshVertex> _ProcVertexBuffer;

		// Token: 0x040139BD RID: 80317
		internal static int __PropertyOffset_ProcIndexBuffer;

		// Token: 0x040139BE RID: 80318
		[Nullable(2)]
		private TArray<uint> _ProcIndexBuffer;

		// Token: 0x040139BF RID: 80319
		internal static int __PropertyOffset_SectionLocalBox;

		// Token: 0x040139C0 RID: 80320
		internal static int __PropertyOffset_bEnableCollision;

		// Token: 0x040139C1 RID: 80321
		internal static int __PropertyOffset_bSectionVisible;
	}
}
