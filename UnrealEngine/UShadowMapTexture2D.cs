using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010E6 RID: 4326
	[UnrealObjectPath("/Script/Engine.ShadowMapTexture2D")]
	[UnrealStructLayout(4048, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 4048)]
	public class UShadowMapTexture2D : UTexture2D, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600F854 RID: 63572 RVA: 0x0016F486 File Offset: 0x0016D686
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UShadowMapTexture2D._ClassPtr;
		}

		// Token: 0x0600F855 RID: 63573 RVA: 0x0016F494 File Offset: 0x0016D694
		public UShadowMapTexture2D() : this(BuiltinUtils.AllocNativeUObject(UShadowMapTexture2D.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600F856 RID: 63574 RVA: 0x0016F4BC File Offset: 0x0016D6BC
		[NullableContext(1)]
		public UShadowMapTexture2D(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UShadowMapTexture2D.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003C7F RID: 15487
		// (get) Token: 0x0600F857 RID: 63575 RVA: 0x0016F4EF File Offset: 0x0016D6EF
		// (set) Token: 0x0600F858 RID: 63576 RVA: 0x0016F503 File Offset: 0x0016D703
		public unsafe TEnumAsByte<EShadowMapFlags> ShadowmapFlags
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UShadowMapTexture2D.__PropertyOffset_ShadowmapFlags);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UShadowMapTexture2D.__PropertyOffset_ShadowmapFlags) = value;
			}
		}

		// Token: 0x0600F859 RID: 63577 RVA: 0x0016F518 File Offset: 0x0016D718
		static UShadowMapTexture2D()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ShadowMapTexture2D");
		}

		// Token: 0x0600F85A RID: 63578 RVA: 0x0016F526 File Offset: 0x0016D726
		protected UShadowMapTexture2D(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008627 RID: 34343
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ShadowMapTexture2D";

		// Token: 0x04008628 RID: 34344
		private static IntPtr _ClassPtr;

		// Token: 0x04008629 RID: 34345
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400862A RID: 34346
		internal static int __PropertyOffset_ShadowmapFlags;
	}
}
