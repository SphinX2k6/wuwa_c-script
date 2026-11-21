using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000452 RID: 1106
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroInteractionEffect.KuroInteractionEffectTraceFoliage")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 104)]
	public class FKuroInteractionEffectTraceFoliage : FKuroInteractionEffectNDCConfigBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006AFC RID: 27388 RVA: 0x0009BCB5 File Offset: 0x00099EB5
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroInteractionEffectTraceFoliage._ScriptStructPtr != 0) ? FKuroInteractionEffectTraceFoliage._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroInteractionEffect.KuroInteractionEffectTraceFoliage", ref FKuroInteractionEffectTraceFoliage._ScriptStructPtr);
		}

		// Token: 0x17001552 RID: 5458
		// (get) Token: 0x06006AFD RID: 27389 RVA: 0x0009BCD9 File Offset: 0x00099ED9
		// (set) Token: 0x06006AFE RID: 27390 RVA: 0x0009BCF8 File Offset: 0x00099EF8
		public TSoftObjectPtr<UFoliageType_InstancedStaticMesh> FoliageMesh
		{
			get
			{
				return new TSoftObjectPtr<UFoliageType_InstancedStaticMesh>(base.NativePtr + (IntPtr)FKuroInteractionEffectTraceFoliage.__PropertyOffset_FoliageMesh, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)FKuroInteractionEffectTraceFoliage.__PropertyOffset_FoliageMesh, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x06006AFF RID: 27391 RVA: 0x0009BD1D File Offset: 0x00099F1D
		public FKuroInteractionEffectTraceFoliage()
		{
		}

		// Token: 0x06006B00 RID: 27392 RVA: 0x0009BD25 File Offset: 0x00099F25
		protected override IntPtr GetUStructPtr()
		{
			return FKuroInteractionEffectTraceFoliage.StaticStruct();
		}

		// Token: 0x06006B01 RID: 27393 RVA: 0x0009BD31 File Offset: 0x00099F31
		[NullableContext(2)]
		public FKuroInteractionEffectTraceFoliage(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006B02 RID: 27394 RVA: 0x0009BD3B File Offset: 0x00099F3B
		public FKuroInteractionEffectTraceFoliage(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006B03 RID: 27395 RVA: 0x0009BD46 File Offset: 0x00099F46
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroInteractionEffectTraceFoliage(Pointer, false, true);
		}

		// Token: 0x06006B04 RID: 27396 RVA: 0x0009BD50 File Offset: 0x00099F50
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroInteractionEffectTraceFoliage(Pointer, MemoryOwner);
		}

		// Token: 0x04002D5F RID: 11615
		public new const string __ObjectPath = "/Script/KuroInteractionEffect.KuroInteractionEffectTraceFoliage";

		// Token: 0x04002D60 RID: 11616
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002D61 RID: 11617
		internal static int __PropertyOffset_FoliageMesh;
	}
}
