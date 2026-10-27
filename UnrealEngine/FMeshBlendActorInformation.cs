using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020022BD RID: 8893
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/MeshBlend.MeshBlendActorInformation")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FMeshBlendActorInformation : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021C88 RID: 138376 RVA: 0x0031F1C2 File Offset: 0x0031D3C2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMeshBlendActorInformation._ScriptStructPtr != 0) ? FMeshBlendActorInformation._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MeshBlend.MeshBlendActorInformation", ref FMeshBlendActorInformation._ScriptStructPtr);
		}

		// Token: 0x1700830A RID: 33546
		// (get) Token: 0x06021C89 RID: 138377 RVA: 0x0031F1E8 File Offset: 0x0031D3E8
		// (set) Token: 0x06021C8A RID: 138378 RVA: 0x0031F22B File Offset: 0x0031D42B
		public FActorBounds Bounds
		{
			get
			{
				base.FastCheckIsValid();
				FActorBounds result;
				if ((result = this._Bounds) == null)
				{
					result = (this._Bounds = new FActorBounds(base.NativePtr + (IntPtr)FMeshBlendActorInformation.__PropertyOffset_Bounds, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FActorBounds.StaticStruct(), base.NativePtr + (IntPtr)FMeshBlendActorInformation.__PropertyOffset_Bounds, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700830B RID: 33547
		// (get) Token: 0x06021C8B RID: 138379 RVA: 0x0031F24C File Offset: 0x0031D44C
		// (set) Token: 0x06021C8C RID: 138380 RVA: 0x0031F25C File Offset: 0x0031D45C
		public unsafe double SkipCheckingUntil
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMeshBlendActorInformation.__PropertyOffset_SkipCheckingUntil);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMeshBlendActorInformation.__PropertyOffset_SkipCheckingUntil) = value;
			}
		}

		// Token: 0x06021C8D RID: 138381 RVA: 0x0031F26D File Offset: 0x0031D46D
		public FMeshBlendActorInformation()
		{
		}

		// Token: 0x06021C8E RID: 138382 RVA: 0x0031F275 File Offset: 0x0031D475
		public FMeshBlendActorInformation(FActorBounds Bounds, double SkipCheckingUntil)
		{
			this.Bounds = Bounds;
			this.SkipCheckingUntil = SkipCheckingUntil;
		}

		// Token: 0x06021C8F RID: 138383 RVA: 0x0031F28B File Offset: 0x0031D48B
		protected override IntPtr GetUStructPtr()
		{
			return FMeshBlendActorInformation.StaticStruct();
		}

		// Token: 0x06021C90 RID: 138384 RVA: 0x0031F297 File Offset: 0x0031D497
		[NullableContext(2)]
		public FMeshBlendActorInformation(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021C91 RID: 138385 RVA: 0x0031F2A1 File Offset: 0x0031D4A1
		public FMeshBlendActorInformation(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021C92 RID: 138386 RVA: 0x0031F2AC File Offset: 0x0031D4AC
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMeshBlendActorInformation(Pointer, false, true);
		}

		// Token: 0x06021C93 RID: 138387 RVA: 0x0031F2B6 File Offset: 0x0031D4B6
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMeshBlendActorInformation(Pointer, MemoryOwner);
		}

		// Token: 0x04012070 RID: 73840
		public const string __ObjectPath = "/Script/MeshBlend.MeshBlendActorInformation";

		// Token: 0x04012071 RID: 73841
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012072 RID: 73842
		internal static int __PropertyOffset_Bounds;

		// Token: 0x04012073 RID: 73843
		[Nullable(2)]
		private FActorBounds _Bounds;

		// Token: 0x04012074 RID: 73844
		internal static int __PropertyOffset_SkipCheckingUntil;
	}
}
