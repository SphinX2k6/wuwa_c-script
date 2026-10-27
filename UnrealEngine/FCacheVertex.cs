using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001FCE RID: 8142
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.CacheVertex")]
	[UnrealStructLayout(64, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FCacheVertex : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601EE3A RID: 126522 RVA: 0x002DE758 File Offset: 0x002DC958
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCacheVertex._ScriptStructPtr != 0) ? FCacheVertex._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.CacheVertex", ref FCacheVertex._ScriptStructPtr);
		}

		// Token: 0x17007AED RID: 31469
		// (get) Token: 0x0601EE3B RID: 126523 RVA: 0x002DE77C File Offset: 0x002DC97C
		// (set) Token: 0x0601EE3C RID: 126524 RVA: 0x002DE7C0 File Offset: 0x002DC9C0
		public TFixedArray<FVector2D> TextureCoordinate
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<FVector2D> result;
				if ((result = this._TextureCoordinate) == null)
				{
					result = (this._TextureCoordinate = new TFixedArray<FVector2D>(base.NativePtr + (IntPtr)FCacheVertex.__PropertyOffset_TextureCoordinate, 4, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TextureCoordinate.CopyAssign(value);
			}
		}

		// Token: 0x17007AEE RID: 31470
		// (get) Token: 0x0601EE3D RID: 126525 RVA: 0x002DE7CE File Offset: 0x002DC9CE
		// (set) Token: 0x0601EE3E RID: 126526 RVA: 0x002DE7E2 File Offset: 0x002DC9E2
		public unsafe FVector4 TangentZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCacheVertex.__PropertyOffset_TangentZ);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCacheVertex.__PropertyOffset_TangentZ) = value;
			}
		}

		// Token: 0x17007AEF RID: 31471
		// (get) Token: 0x0601EE3F RID: 126527 RVA: 0x002DE7F7 File Offset: 0x002DC9F7
		// (set) Token: 0x0601EE40 RID: 126528 RVA: 0x002DE80B File Offset: 0x002DCA0B
		public unsafe FVector4 TangentX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCacheVertex.__PropertyOffset_TangentX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCacheVertex.__PropertyOffset_TangentX) = value;
			}
		}

		// Token: 0x0601EE41 RID: 126529 RVA: 0x002DE820 File Offset: 0x002DCA20
		public FCacheVertex()
		{
		}

		// Token: 0x0601EE42 RID: 126530 RVA: 0x002DE828 File Offset: 0x002DCA28
		public FCacheVertex(TFixedArray<FVector2D> TextureCoordinate, FVector4 TangentZ, FVector4 TangentX)
		{
			this.TextureCoordinate = TextureCoordinate;
			this.TangentZ = TangentZ;
			this.TangentX = TangentX;
		}

		// Token: 0x0601EE43 RID: 126531 RVA: 0x002DE845 File Offset: 0x002DCA45
		protected override IntPtr GetUStructPtr()
		{
			return FCacheVertex.StaticStruct();
		}

		// Token: 0x0601EE44 RID: 126532 RVA: 0x002DE851 File Offset: 0x002DCA51
		[NullableContext(2)]
		public FCacheVertex(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601EE45 RID: 126533 RVA: 0x002DE85B File Offset: 0x002DCA5B
		public FCacheVertex(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601EE46 RID: 126534 RVA: 0x002DE866 File Offset: 0x002DCA66
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCacheVertex(Pointer, false, true);
		}

		// Token: 0x0601EE47 RID: 126535 RVA: 0x002DE870 File Offset: 0x002DCA70
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCacheVertex(Pointer, MemoryOwner);
		}

		// Token: 0x04010AFB RID: 68347
		public const string __ObjectPath = "/Script/LGUI.CacheVertex";

		// Token: 0x04010AFC RID: 68348
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010AFD RID: 68349
		internal static int __PropertyOffset_TextureCoordinate;

		// Token: 0x04010AFE RID: 68350
		[Nullable(2)]
		private TFixedArray<FVector2D> _TextureCoordinate;

		// Token: 0x04010AFF RID: 68351
		internal static int __PropertyOffset_TangentZ;

		// Token: 0x04010B00 RID: 68352
		internal static int __PropertyOffset_TangentX;
	}
}
