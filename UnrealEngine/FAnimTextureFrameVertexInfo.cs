using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000847 RID: 2119
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AnimTextureFrameVertexInfo")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FAnimTextureFrameVertexInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007227 RID: 29223 RVA: 0x000A36EC File Offset: 0x000A18EC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimTextureFrameVertexInfo._ScriptStructPtr != 0) ? FAnimTextureFrameVertexInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimTextureFrameVertexInfo", ref FAnimTextureFrameVertexInfo._ScriptStructPtr);
		}

		// Token: 0x17001ADD RID: 6877
		// (get) Token: 0x06007228 RID: 29224 RVA: 0x000A3710 File Offset: 0x000A1910
		// (set) Token: 0x06007229 RID: 29225 RVA: 0x000A3753 File Offset: 0x000A1953
		public TArray<int> Indices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._Indices) == null)
				{
					result = (this._Indices = new TArray<int>(base.NativePtr + (IntPtr)FAnimTextureFrameVertexInfo.__PropertyOffset_Indices, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Indices.CopyAssign(value);
			}
		}

		// Token: 0x0600722A RID: 29226 RVA: 0x000A3761 File Offset: 0x000A1961
		public FAnimTextureFrameVertexInfo()
		{
		}

		// Token: 0x0600722B RID: 29227 RVA: 0x000A3769 File Offset: 0x000A1969
		public FAnimTextureFrameVertexInfo(TArray<int> Indices)
		{
			this.Indices = Indices;
		}

		// Token: 0x0600722C RID: 29228 RVA: 0x000A3778 File Offset: 0x000A1978
		protected override IntPtr GetUStructPtr()
		{
			return FAnimTextureFrameVertexInfo.StaticStruct();
		}

		// Token: 0x0600722D RID: 29229 RVA: 0x000A3784 File Offset: 0x000A1984
		[NullableContext(2)]
		public FAnimTextureFrameVertexInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600722E RID: 29230 RVA: 0x000A378E File Offset: 0x000A198E
		public FAnimTextureFrameVertexInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600722F RID: 29231 RVA: 0x000A3799 File Offset: 0x000A1999
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimTextureFrameVertexInfo(Pointer, false, true);
		}

		// Token: 0x06007230 RID: 29232 RVA: 0x000A37A3 File Offset: 0x000A19A3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimTextureFrameVertexInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040036D0 RID: 14032
		public const string __ObjectPath = "/Script/Engine.AnimTextureFrameVertexInfo";

		// Token: 0x040036D1 RID: 14033
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040036D2 RID: 14034
		internal static int __PropertyOffset_Indices;

		// Token: 0x040036D3 RID: 14035
		[Nullable(2)]
		private TArray<int> _Indices;
	}
}
