using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003B0 RID: 944
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AugmentedReality.ARMeshUpdatePayload")]
	[UnrealStructLayout(96, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FARMeshUpdatePayload : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600344B RID: 13387 RVA: 0x0004FF4E File Offset: 0x0004E14E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FARMeshUpdatePayload._ScriptStructPtr != 0) ? FARMeshUpdatePayload._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AugmentedReality.ARMeshUpdatePayload", ref FARMeshUpdatePayload._ScriptStructPtr);
		}

		// Token: 0x17000C84 RID: 3204
		// (get) Token: 0x0600344C RID: 13388 RVA: 0x0004FF74 File Offset: 0x0004E174
		// (set) Token: 0x0600344D RID: 13389 RVA: 0x0004FFB7 File Offset: 0x0004E1B7
		public FARSessionPayload SessionPayload
		{
			get
			{
				base.FastCheckIsValid();
				FARSessionPayload result;
				if ((result = this._SessionPayload) == null)
				{
					result = (this._SessionPayload = new FARSessionPayload(base.NativePtr + (IntPtr)FARMeshUpdatePayload.__PropertyOffset_SessionPayload, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FARSessionPayload.StaticStruct(), base.NativePtr + (IntPtr)FARMeshUpdatePayload.__PropertyOffset_SessionPayload, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000C85 RID: 3205
		// (get) Token: 0x0600344E RID: 13390 RVA: 0x0004FFD8 File Offset: 0x0004E1D8
		// (set) Token: 0x0600344F RID: 13391 RVA: 0x0004FFEC File Offset: 0x0004E1EC
		public unsafe FTransform WorldTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FARMeshUpdatePayload.__PropertyOffset_WorldTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FARMeshUpdatePayload.__PropertyOffset_WorldTransform) = value;
			}
		}

		// Token: 0x17000C86 RID: 3206
		// (get) Token: 0x06003450 RID: 13392 RVA: 0x00050001 File Offset: 0x0004E201
		// (set) Token: 0x06003451 RID: 13393 RVA: 0x00050011 File Offset: 0x0004E211
		public unsafe EARObjectClassification ObjectClassification
		{
			get
			{
				return (EARObjectClassification)(*(base.NativePtr + (IntPtr)FARMeshUpdatePayload.__PropertyOffset_ObjectClassification));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FARMeshUpdatePayload.__PropertyOffset_ObjectClassification) = (byte)value;
			}
		}

		// Token: 0x06003452 RID: 13394 RVA: 0x00050022 File Offset: 0x0004E222
		public FARMeshUpdatePayload()
		{
		}

		// Token: 0x06003453 RID: 13395 RVA: 0x0005002A File Offset: 0x0004E22A
		public FARMeshUpdatePayload(FARSessionPayload SessionPayload, FTransform WorldTransform, EARObjectClassification ObjectClassification)
		{
			this.SessionPayload = SessionPayload;
			this.WorldTransform = WorldTransform;
			this.ObjectClassification = ObjectClassification;
		}

		// Token: 0x06003454 RID: 13396 RVA: 0x00050047 File Offset: 0x0004E247
		protected override IntPtr GetUStructPtr()
		{
			return FARMeshUpdatePayload.StaticStruct();
		}

		// Token: 0x06003455 RID: 13397 RVA: 0x00050053 File Offset: 0x0004E253
		[NullableContext(2)]
		public FARMeshUpdatePayload(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003456 RID: 13398 RVA: 0x0005005D File Offset: 0x0004E25D
		public FARMeshUpdatePayload(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003457 RID: 13399 RVA: 0x00050068 File Offset: 0x0004E268
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FARMeshUpdatePayload(Pointer, false, true);
		}

		// Token: 0x06003458 RID: 13400 RVA: 0x00050072 File Offset: 0x0004E272
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FARMeshUpdatePayload(Pointer, MemoryOwner);
		}

		// Token: 0x040016B3 RID: 5811
		public const string __ObjectPath = "/Script/AugmentedReality.ARMeshUpdatePayload";

		// Token: 0x040016B4 RID: 5812
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040016B5 RID: 5813
		internal static int __PropertyOffset_SessionPayload;

		// Token: 0x040016B6 RID: 5814
		[Nullable(2)]
		private FARSessionPayload _SessionPayload;

		// Token: 0x040016B7 RID: 5815
		internal static int __PropertyOffset_WorldTransform;

		// Token: 0x040016B8 RID: 5816
		internal static int __PropertyOffset_ObjectClassification;
	}
}
