using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001ABB RID: 6843
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroBridgeChunkMeshList")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FKuroBridgeChunkMeshList : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601961C RID: 103964 RVA: 0x00258182 File Offset: 0x00256382
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroBridgeChunkMeshList._ScriptStructPtr != 0) ? FKuroBridgeChunkMeshList._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroBridgeChunkMeshList", ref FKuroBridgeChunkMeshList._ScriptStructPtr);
		}

		// Token: 0x1700654F RID: 25935
		// (get) Token: 0x0601961D RID: 103965 RVA: 0x002581A8 File Offset: 0x002563A8
		// (set) Token: 0x0601961E RID: 103966 RVA: 0x002581EB File Offset: 0x002563EB
		public TArray<UStaticMesh> Meshes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UStaticMesh> result;
				if ((result = this._Meshes) == null)
				{
					result = (this._Meshes = new TArray<UStaticMesh>(base.NativePtr + (IntPtr)FKuroBridgeChunkMeshList.__PropertyOffset_Meshes, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Meshes.CopyAssign(value);
			}
		}

		// Token: 0x0601961F RID: 103967 RVA: 0x002581F9 File Offset: 0x002563F9
		public FKuroBridgeChunkMeshList()
		{
		}

		// Token: 0x06019620 RID: 103968 RVA: 0x00258201 File Offset: 0x00256401
		public FKuroBridgeChunkMeshList(TArray<UStaticMesh> Meshes)
		{
			this.Meshes = Meshes;
		}

		// Token: 0x06019621 RID: 103969 RVA: 0x00258210 File Offset: 0x00256410
		protected override IntPtr GetUStructPtr()
		{
			return FKuroBridgeChunkMeshList.StaticStruct();
		}

		// Token: 0x06019622 RID: 103970 RVA: 0x0025821C File Offset: 0x0025641C
		[NullableContext(2)]
		public FKuroBridgeChunkMeshList(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06019623 RID: 103971 RVA: 0x00258226 File Offset: 0x00256426
		public FKuroBridgeChunkMeshList(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06019624 RID: 103972 RVA: 0x00258231 File Offset: 0x00256431
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroBridgeChunkMeshList(Pointer, false, true);
		}

		// Token: 0x06019625 RID: 103973 RVA: 0x0025823B File Offset: 0x0025643B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroBridgeChunkMeshList(Pointer, MemoryOwner);
		}

		// Token: 0x0400DD4D RID: 56653
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroBridgeChunkMeshList";

		// Token: 0x0400DD4E RID: 56654
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400DD4F RID: 56655
		internal static int __PropertyOffset_Meshes;

		// Token: 0x0400DD50 RID: 56656
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UStaticMesh> _Meshes;
	}
}
