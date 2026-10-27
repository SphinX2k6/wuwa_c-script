using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001F05 RID: 7941
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.PreloadObjectCollection")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FPreloadObjectCollection : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E241 RID: 123457 RVA: 0x002CCEF6 File Offset: 0x002CB0F6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPreloadObjectCollection._ScriptStructPtr != 0) ? FPreloadObjectCollection._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroUtility.PreloadObjectCollection", ref FPreloadObjectCollection._ScriptStructPtr);
		}

		// Token: 0x170077C5 RID: 30661
		// (get) Token: 0x0601E242 RID: 123458 RVA: 0x002CCF1C File Offset: 0x002CB11C
		// (set) Token: 0x0601E243 RID: 123459 RVA: 0x002CCF5F File Offset: 0x002CB15F
		public TArray<UObject> Assets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UObject> result;
				if ((result = this._Assets) == null)
				{
					result = (this._Assets = new TArray<UObject>(base.NativePtr + (IntPtr)FPreloadObjectCollection.__PropertyOffset_Assets, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Assets.CopyAssign(value);
			}
		}

		// Token: 0x0601E244 RID: 123460 RVA: 0x002CCF6D File Offset: 0x002CB16D
		public FPreloadObjectCollection()
		{
		}

		// Token: 0x0601E245 RID: 123461 RVA: 0x002CCF75 File Offset: 0x002CB175
		public FPreloadObjectCollection(TArray<UObject> Assets)
		{
			this.Assets = Assets;
		}

		// Token: 0x0601E246 RID: 123462 RVA: 0x002CCF84 File Offset: 0x002CB184
		protected override IntPtr GetUStructPtr()
		{
			return FPreloadObjectCollection.StaticStruct();
		}

		// Token: 0x0601E247 RID: 123463 RVA: 0x002CCF90 File Offset: 0x002CB190
		[NullableContext(2)]
		public FPreloadObjectCollection(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E248 RID: 123464 RVA: 0x002CCF9A File Offset: 0x002CB19A
		public FPreloadObjectCollection(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E249 RID: 123465 RVA: 0x002CCFA5 File Offset: 0x002CB1A5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPreloadObjectCollection(Pointer, false, true);
		}

		// Token: 0x0601E24A RID: 123466 RVA: 0x002CCFAF File Offset: 0x002CB1AF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPreloadObjectCollection(Pointer, MemoryOwner);
		}

		// Token: 0x0401046F RID: 66671
		public const string __ObjectPath = "/Script/KuroUtility.PreloadObjectCollection";

		// Token: 0x04010470 RID: 66672
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010471 RID: 66673
		internal static int __PropertyOffset_Assets;

		// Token: 0x04010472 RID: 66674
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UObject> _Assets;
	}
}
