using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D4D RID: 3405
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.LightMapVirtualTexture2D")]
	[UnrealStructLayout(4064, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 4064)]
	public class ULightMapVirtualTexture2D : UTexture2D, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B7C9 RID: 47049 RVA: 0x0010573A File Offset: 0x0010393A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULightMapVirtualTexture2D._ClassPtr;
		}

		// Token: 0x0600B7CA RID: 47050 RVA: 0x00105748 File Offset: 0x00103948
		public ULightMapVirtualTexture2D() : this(BuiltinUtils.AllocNativeUObject(ULightMapVirtualTexture2D.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B7CB RID: 47051 RVA: 0x00105770 File Offset: 0x00103970
		public ULightMapVirtualTexture2D(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULightMapVirtualTexture2D.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002A0A RID: 10762
		// (get) Token: 0x0600B7CC RID: 47052 RVA: 0x001057A4 File Offset: 0x001039A4
		// (set) Token: 0x0600B7CD RID: 47053 RVA: 0x001057DD File Offset: 0x001039DD
		public TArray<sbyte> TypeToLayer
		{
			get
			{
				base.FastCheckIsValid();
				TArray<sbyte> result;
				if ((result = this._TypeToLayer) == null)
				{
					result = (this._TypeToLayer = new TArray<sbyte>(base.NativePtr + (IntPtr)ULightMapVirtualTexture2D.__PropertyOffset_TypeToLayer, this));
				}
				return result;
			}
			set
			{
				this.TypeToLayer.CopyAssign(value);
			}
		}

		// Token: 0x0600B7CE RID: 47054 RVA: 0x001057EB File Offset: 0x001039EB
		static ULightMapVirtualTexture2D()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.LightMapVirtualTexture2D");
		}

		// Token: 0x0600B7CF RID: 47055 RVA: 0x001057F9 File Offset: 0x001039F9
		protected ULightMapVirtualTexture2D(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006044 RID: 24644
		public new const string __ObjectPath = "/Script/Engine.LightMapVirtualTexture2D";

		// Token: 0x04006045 RID: 24645
		private static IntPtr _ClassPtr;

		// Token: 0x04006046 RID: 24646
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006047 RID: 24647
		internal static int __PropertyOffset_TypeToLayer;

		// Token: 0x04006048 RID: 24648
		[Nullable(2)]
		private TArray<sbyte> _TypeToLayer;
	}
}
