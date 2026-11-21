using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000612 RID: 1554
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.PreloadObjectCollection")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FPreloadObjectCollection : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008881 RID: 34945 RVA: 0x000CDE7E File Offset: 0x000CC07E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPreloadObjectCollection._ScriptStructPtr != 0) ? FPreloadObjectCollection._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroUtility.PreloadObjectCollection", ref FPreloadObjectCollection._ScriptStructPtr);
		}

		// Token: 0x17001977 RID: 6519
		// (get) Token: 0x06008882 RID: 34946 RVA: 0x000CDEA4 File Offset: 0x000CC0A4
		// (set) Token: 0x06008883 RID: 34947 RVA: 0x000CDEE7 File Offset: 0x000CC0E7
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

		// Token: 0x06008884 RID: 34948 RVA: 0x000CDEF5 File Offset: 0x000CC0F5
		public FPreloadObjectCollection()
		{
		}

		// Token: 0x06008885 RID: 34949 RVA: 0x000CDEFD File Offset: 0x000CC0FD
		protected override IntPtr GetUStructPtr()
		{
			return FPreloadObjectCollection.StaticStruct();
		}

		// Token: 0x06008886 RID: 34950 RVA: 0x000CDF09 File Offset: 0x000CC109
		[NullableContext(2)]
		public FPreloadObjectCollection(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008887 RID: 34951 RVA: 0x000CDF13 File Offset: 0x000CC113
		public FPreloadObjectCollection(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008888 RID: 34952 RVA: 0x000CDF1E File Offset: 0x000CC11E
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPreloadObjectCollection(Pointer, false, true);
		}

		// Token: 0x06008889 RID: 34953 RVA: 0x000CDF28 File Offset: 0x000CC128
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPreloadObjectCollection(Pointer, MemoryOwner);
		}

		// Token: 0x04003B41 RID: 15169
		public const string __ObjectPath = "/Script/KuroUtility.PreloadObjectCollection";

		// Token: 0x04003B42 RID: 15170
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003B43 RID: 15171
		internal static int __PropertyOffset_Assets;

		// Token: 0x04003B44 RID: 15172
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UObject> _Assets;
	}
}
