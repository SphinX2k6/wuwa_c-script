using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003B7 RID: 951
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AugmentedReality.ARPlaneUpdatePayload")]
	[UnrealStructLayout(128, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 128)]
	public class FARPlaneUpdatePayload : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060034C1 RID: 13505 RVA: 0x0005083B File Offset: 0x0004EA3B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FARPlaneUpdatePayload._ScriptStructPtr != 0) ? FARPlaneUpdatePayload._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AugmentedReality.ARPlaneUpdatePayload", ref FARPlaneUpdatePayload._ScriptStructPtr);
		}

		// Token: 0x17000C96 RID: 3222
		// (get) Token: 0x060034C2 RID: 13506 RVA: 0x00050860 File Offset: 0x0004EA60
		// (set) Token: 0x060034C3 RID: 13507 RVA: 0x000508A3 File Offset: 0x0004EAA3
		public FARSessionPayload SessionPayload
		{
			get
			{
				base.FastCheckIsValid();
				FARSessionPayload result;
				if ((result = this._SessionPayload) == null)
				{
					result = (this._SessionPayload = new FARSessionPayload(base.NativePtr + (IntPtr)FARPlaneUpdatePayload.__PropertyOffset_SessionPayload, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FARSessionPayload.StaticStruct(), base.NativePtr + (IntPtr)FARPlaneUpdatePayload.__PropertyOffset_SessionPayload, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000C97 RID: 3223
		// (get) Token: 0x060034C4 RID: 13508 RVA: 0x000508C4 File Offset: 0x0004EAC4
		// (set) Token: 0x060034C5 RID: 13509 RVA: 0x000508D8 File Offset: 0x0004EAD8
		public unsafe FTransform WorldTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FARPlaneUpdatePayload.__PropertyOffset_WorldTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FARPlaneUpdatePayload.__PropertyOffset_WorldTransform) = value;
			}
		}

		// Token: 0x17000C98 RID: 3224
		// (get) Token: 0x060034C6 RID: 13510 RVA: 0x000508ED File Offset: 0x0004EAED
		// (set) Token: 0x060034C7 RID: 13511 RVA: 0x00050901 File Offset: 0x0004EB01
		public unsafe FVector Center
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FARPlaneUpdatePayload.__PropertyOffset_Center);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FARPlaneUpdatePayload.__PropertyOffset_Center) = value;
			}
		}

		// Token: 0x17000C99 RID: 3225
		// (get) Token: 0x060034C8 RID: 13512 RVA: 0x00050916 File Offset: 0x0004EB16
		// (set) Token: 0x060034C9 RID: 13513 RVA: 0x0005092A File Offset: 0x0004EB2A
		public unsafe FVector Extents
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FARPlaneUpdatePayload.__PropertyOffset_Extents);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FARPlaneUpdatePayload.__PropertyOffset_Extents) = value;
			}
		}

		// Token: 0x17000C9A RID: 3226
		// (get) Token: 0x060034CA RID: 13514 RVA: 0x00050940 File Offset: 0x0004EB40
		// (set) Token: 0x060034CB RID: 13515 RVA: 0x00050983 File Offset: 0x0004EB83
		public TArray<FVector> BoundaryVertices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._BoundaryVertices) == null)
				{
					result = (this._BoundaryVertices = new TArray<FVector>(base.NativePtr + (IntPtr)FARPlaneUpdatePayload.__PropertyOffset_BoundaryVertices, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BoundaryVertices.CopyAssign(value);
			}
		}

		// Token: 0x17000C9B RID: 3227
		// (get) Token: 0x060034CC RID: 13516 RVA: 0x00050991 File Offset: 0x0004EB91
		// (set) Token: 0x060034CD RID: 13517 RVA: 0x000509A1 File Offset: 0x0004EBA1
		public unsafe EARObjectClassification ObjectClassification
		{
			get
			{
				return (EARObjectClassification)(*(base.NativePtr + (IntPtr)FARPlaneUpdatePayload.__PropertyOffset_ObjectClassification));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FARPlaneUpdatePayload.__PropertyOffset_ObjectClassification) = (byte)value;
			}
		}

		// Token: 0x060034CE RID: 13518 RVA: 0x000509B2 File Offset: 0x0004EBB2
		public FARPlaneUpdatePayload()
		{
		}

		// Token: 0x060034CF RID: 13519 RVA: 0x000509BA File Offset: 0x0004EBBA
		public FARPlaneUpdatePayload(FARSessionPayload SessionPayload, FTransform WorldTransform, FVector Center, FVector Extents, TArray<FVector> BoundaryVertices, EARObjectClassification ObjectClassification)
		{
			this.SessionPayload = SessionPayload;
			this.WorldTransform = WorldTransform;
			this.Center = Center;
			this.Extents = Extents;
			this.BoundaryVertices = BoundaryVertices;
			this.ObjectClassification = ObjectClassification;
		}

		// Token: 0x060034D0 RID: 13520 RVA: 0x000509EF File Offset: 0x0004EBEF
		protected override IntPtr GetUStructPtr()
		{
			return FARPlaneUpdatePayload.StaticStruct();
		}

		// Token: 0x060034D1 RID: 13521 RVA: 0x000509FB File Offset: 0x0004EBFB
		[NullableContext(2)]
		public FARPlaneUpdatePayload(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060034D2 RID: 13522 RVA: 0x00050A05 File Offset: 0x0004EC05
		public FARPlaneUpdatePayload(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060034D3 RID: 13523 RVA: 0x00050A10 File Offset: 0x0004EC10
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FARPlaneUpdatePayload(Pointer, false, true);
		}

		// Token: 0x060034D4 RID: 13524 RVA: 0x00050A1A File Offset: 0x0004EC1A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FARPlaneUpdatePayload(Pointer, MemoryOwner);
		}

		// Token: 0x040016DE RID: 5854
		public const string __ObjectPath = "/Script/AugmentedReality.ARPlaneUpdatePayload";

		// Token: 0x040016DF RID: 5855
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040016E0 RID: 5856
		internal static int __PropertyOffset_SessionPayload;

		// Token: 0x040016E1 RID: 5857
		[Nullable(2)]
		private FARSessionPayload _SessionPayload;

		// Token: 0x040016E2 RID: 5858
		internal static int __PropertyOffset_WorldTransform;

		// Token: 0x040016E3 RID: 5859
		internal static int __PropertyOffset_Center;

		// Token: 0x040016E4 RID: 5860
		internal static int __PropertyOffset_Extents;

		// Token: 0x040016E5 RID: 5861
		internal static int __PropertyOffset_BoundaryVertices;

		// Token: 0x040016E6 RID: 5862
		[Nullable(2)]
		private TArray<FVector> _BoundaryVertices;

		// Token: 0x040016E7 RID: 5863
		internal static int __PropertyOffset_ObjectClassification;
	}
}
