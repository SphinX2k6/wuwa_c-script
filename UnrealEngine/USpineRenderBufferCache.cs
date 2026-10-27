using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200210A RID: 8458
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.SpineRenderBufferCache")]
	[UnrealStructLayout(496, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 496)]
	public class USpineRenderBufferCache : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FD3E RID: 130366 RVA: 0x002F56AA File Offset: 0x002F38AA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USpineRenderBufferCache._ClassPtr;
		}

		// Token: 0x0601FD3F RID: 130367 RVA: 0x002F56B8 File Offset: 0x002F38B8
		public USpineRenderBufferCache() : this(BuiltinUtils.AllocNativeUObject(USpineRenderBufferCache.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FD40 RID: 130368 RVA: 0x002F56E0 File Offset: 0x002F38E0
		public USpineRenderBufferCache(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USpineRenderBufferCache.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007D31 RID: 32049
		// (get) Token: 0x0601FD41 RID: 130369 RVA: 0x002F5714 File Offset: 0x002F3914
		// (set) Token: 0x0601FD42 RID: 130370 RVA: 0x002F574E File Offset: 0x002F394E
		public TFixedArray<FSpineRenderBuffer> Buffers
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<FSpineRenderBuffer> result;
				if ((result = this._Buffers) == null)
				{
					result = (this._Buffers = new TFixedArray<FSpineRenderBuffer>(base.NativePtr + (IntPtr)USpineRenderBufferCache.__PropertyOffset_Buffers, 2, this));
				}
				return result;
			}
			set
			{
				this.Buffers.CopyAssign(value);
			}
		}

		// Token: 0x0601FD43 RID: 130371 RVA: 0x002F575C File Offset: 0x002F395C
		static USpineRenderBufferCache()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.SpineRenderBufferCache");
		}

		// Token: 0x0601FD44 RID: 130372 RVA: 0x002F576A File Offset: 0x002F396A
		protected USpineRenderBufferCache(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401126D RID: 70253
		public new const string __ObjectPath = "/Script/LGUI.SpineRenderBufferCache";

		// Token: 0x0401126E RID: 70254
		private static IntPtr _ClassPtr;

		// Token: 0x0401126F RID: 70255
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011270 RID: 70256
		internal static int __PropertyOffset_Buffers;

		// Token: 0x04011271 RID: 70257
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<FSpineRenderBuffer> _Buffers;
	}
}
