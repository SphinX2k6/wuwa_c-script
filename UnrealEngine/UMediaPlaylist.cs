using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002298 RID: 8856
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MediaAssets.MediaPlaylist")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UMediaPlaylist : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021AF0 RID: 137968 RVA: 0x0031CFA9 File Offset: 0x0031B1A9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMediaPlaylist._ClassPtr;
		}

		// Token: 0x06021AF1 RID: 137969 RVA: 0x0031CFB8 File Offset: 0x0031B1B8
		public UMediaPlaylist() : this(BuiltinUtils.AllocNativeUObject(UMediaPlaylist.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021AF2 RID: 137970 RVA: 0x0031CFE0 File Offset: 0x0031B1E0
		[NullableContext(1)]
		public UMediaPlaylist(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMediaPlaylist.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170082BF RID: 33471
		// (get) Token: 0x06021AF3 RID: 137971 RVA: 0x0031D014 File Offset: 0x0031B214
		// (set) Token: 0x06021AF4 RID: 137972 RVA: 0x0031D04D File Offset: 0x0031B24D
		[Nullable(1)]
		public TArray<UMediaSource> Items
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UMediaSource> result;
				if ((result = this._Items) == null)
				{
					result = (this._Items = new TArray<UMediaSource>(base.NativePtr + (IntPtr)UMediaPlaylist.__PropertyOffset_Items, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Items.CopyAssign(value);
			}
		}

		// Token: 0x06021AF5 RID: 137973 RVA: 0x0031D05B File Offset: 0x0031B25B
		public bool Replace(int Index, UMediaSource Replacement)
		{
			return UMediaPlaylist.__Replace_Internal(base.NativePtr, Index, (Replacement != null) ? Replacement.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06021AF6 RID: 137974 RVA: 0x0031D079 File Offset: 0x0031B279
		public bool RemoveAt(int Index)
		{
			return UMediaPlaylist.__RemoveAt_Internal(base.NativePtr, Index);
		}

		// Token: 0x06021AF7 RID: 137975 RVA: 0x0031D087 File Offset: 0x0031B287
		public bool Remove(UMediaSource MediaSource)
		{
			return UMediaPlaylist.__Remove_Internal(base.NativePtr, (MediaSource != null) ? MediaSource.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06021AF8 RID: 137976 RVA: 0x0031D0A4 File Offset: 0x0031B2A4
		public int Num()
		{
			return UMediaPlaylist.__Num_Internal(base.NativePtr);
		}

		// Token: 0x06021AF9 RID: 137977 RVA: 0x0031D0B1 File Offset: 0x0031B2B1
		public void Insert(UMediaSource MediaSource, int Index)
		{
			UMediaPlaylist.__Insert_Internal(base.NativePtr, (MediaSource != null) ? MediaSource.NativePtr : IntPtr.Zero, Index);
		}

		// Token: 0x06021AFA RID: 137978 RVA: 0x0031D0D0 File Offset: 0x0031B2D0
		public unsafe UMediaSource GetRandom(ref int OutIndex)
		{
			fixed (int* ptr = &OutIndex)
			{
				void* ptr2 = (void*)ptr;
				return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMediaSource>(UMediaPlaylist.__GetRandom_Internal(base.NativePtr, ref OutIndex));
			}
		}

		// Token: 0x06021AFB RID: 137979 RVA: 0x0031D0F4 File Offset: 0x0031B2F4
		public unsafe UMediaSource GetPrevious(ref int InOutIndex)
		{
			fixed (int* ptr = &InOutIndex)
			{
				void* ptr2 = (void*)ptr;
				return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMediaSource>(UMediaPlaylist.__GetPrevious_Internal(base.NativePtr, ref InOutIndex));
			}
		}

		// Token: 0x06021AFC RID: 137980 RVA: 0x0031D118 File Offset: 0x0031B318
		public unsafe UMediaSource GetNext(ref int InOutIndex)
		{
			fixed (int* ptr = &InOutIndex)
			{
				void* ptr2 = (void*)ptr;
				return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMediaSource>(UMediaPlaylist.__GetNext_Internal(base.NativePtr, ref InOutIndex));
			}
		}

		// Token: 0x06021AFD RID: 137981 RVA: 0x0031D13B File Offset: 0x0031B33B
		public UMediaSource Get(int Index)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMediaSource>(UMediaPlaylist.__Get_Internal(base.NativePtr, Index));
		}

		// Token: 0x06021AFE RID: 137982 RVA: 0x0031D150 File Offset: 0x0031B350
		[NullableContext(1)]
		public unsafe bool AddUrl(string Url)
		{
			FString fstring = FString.AllocTemp(Url);
			bool result = UMediaPlaylist.__AddUrl_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06021AFF RID: 137983 RVA: 0x0031D17C File Offset: 0x0031B37C
		[NullableContext(1)]
		public unsafe bool AddFile(string FilePath)
		{
			FString fstring = FString.AllocTemp(FilePath);
			bool result = UMediaPlaylist.__AddFile_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06021B00 RID: 137984 RVA: 0x0031D1A6 File Offset: 0x0031B3A6
		public bool Add(UMediaSource MediaSource)
		{
			return UMediaPlaylist.__Add_Internal(base.NativePtr, (MediaSource != null) ? MediaSource.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06021B01 RID: 137985
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Replace_Internal(IntPtr @this, int Index, IntPtr Replacement);

		// Token: 0x06021B02 RID: 137986
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __RemoveAt_Internal(IntPtr @this, int Index);

		// Token: 0x06021B03 RID: 137987
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Remove_Internal(IntPtr @this, IntPtr MediaSource);

		// Token: 0x06021B04 RID: 137988
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __Num_Internal(IntPtr @this);

		// Token: 0x06021B05 RID: 137989
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Insert_Internal(IntPtr @this, IntPtr MediaSource, int Index);

		// Token: 0x06021B06 RID: 137990
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetRandom_Internal(IntPtr @this, ref int OutIndex);

		// Token: 0x06021B07 RID: 137991
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetPrevious_Internal(IntPtr @this, ref int InOutIndex);

		// Token: 0x06021B08 RID: 137992
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetNext_Internal(IntPtr @this, ref int InOutIndex);

		// Token: 0x06021B09 RID: 137993
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Get_Internal(IntPtr @this, int Index);

		// Token: 0x06021B0A RID: 137994
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __AddUrl_Internal(IntPtr @this, in FString Url);

		// Token: 0x06021B0B RID: 137995
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __AddFile_Internal(IntPtr @this, in FString FilePath);

		// Token: 0x06021B0C RID: 137996
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Add_Internal(IntPtr @this, IntPtr MediaSource);

		// Token: 0x06021B0D RID: 137997 RVA: 0x0031D1C3 File Offset: 0x0031B3C3
		static UMediaPlaylist()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MediaAssets.MediaPlaylist");
		}

		// Token: 0x06021B0E RID: 137998 RVA: 0x0031D1D1 File Offset: 0x0031B3D1
		protected UMediaPlaylist(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011F9C RID: 73628
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MediaAssets.MediaPlaylist";

		// Token: 0x04011F9D RID: 73629
		private static IntPtr _ClassPtr;

		// Token: 0x04011F9E RID: 73630
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011F9F RID: 73631
		internal static int __PropertyOffset_Items;

		// Token: 0x04011FA0 RID: 73632
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMediaSource> _Items;
	}
}
