using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F77 RID: 8055
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Landscape.LandscapeInfo")]
	[UnrealStructLayout(640, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 640)]
	public class ULandscapeInfo : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E905 RID: 125189 RVA: 0x002D6CE2 File Offset: 0x002D4EE2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULandscapeInfo._ClassPtr;
		}

		// Token: 0x0601E906 RID: 125190 RVA: 0x002D6CF0 File Offset: 0x002D4EF0
		public ULandscapeInfo() : this(BuiltinUtils.AllocNativeUObject(ULandscapeInfo.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E907 RID: 125191 RVA: 0x002D6D18 File Offset: 0x002D4F18
		public ULandscapeInfo(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULandscapeInfo.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700799C RID: 31132
		// (get) Token: 0x0601E908 RID: 125192 RVA: 0x002D6D4B File Offset: 0x002D4F4B
		// (set) Token: 0x0601E909 RID: 125193 RVA: 0x002D6D5F File Offset: 0x002D4F5F
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TLazyObjectPtr<ALandscape> LandscapeActor
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeInfo.__PropertyOffset_LandscapeActor);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeInfo.__PropertyOffset_LandscapeActor) = value;
			}
		}

		// Token: 0x1700799D RID: 31133
		// (get) Token: 0x0601E90A RID: 125194 RVA: 0x002D6D74 File Offset: 0x002D4F74
		// (set) Token: 0x0601E90B RID: 125195 RVA: 0x002D6D88 File Offset: 0x002D4F88
		public unsafe FGuid LandscapeGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeInfo.__PropertyOffset_LandscapeGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeInfo.__PropertyOffset_LandscapeGuid) = value;
			}
		}

		// Token: 0x1700799E RID: 31134
		// (get) Token: 0x0601E90C RID: 125196 RVA: 0x002D6D9D File Offset: 0x002D4F9D
		// (set) Token: 0x0601E90D RID: 125197 RVA: 0x002D6DAD File Offset: 0x002D4FAD
		public unsafe int ComponentSizeQuads
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeInfo.__PropertyOffset_ComponentSizeQuads);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeInfo.__PropertyOffset_ComponentSizeQuads) = value;
			}
		}

		// Token: 0x1700799F RID: 31135
		// (get) Token: 0x0601E90E RID: 125198 RVA: 0x002D6DBE File Offset: 0x002D4FBE
		// (set) Token: 0x0601E90F RID: 125199 RVA: 0x002D6DCE File Offset: 0x002D4FCE
		public unsafe int SubsectionSizeQuads
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeInfo.__PropertyOffset_SubsectionSizeQuads);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeInfo.__PropertyOffset_SubsectionSizeQuads) = value;
			}
		}

		// Token: 0x170079A0 RID: 31136
		// (get) Token: 0x0601E910 RID: 125200 RVA: 0x002D6DDF File Offset: 0x002D4FDF
		// (set) Token: 0x0601E911 RID: 125201 RVA: 0x002D6DEF File Offset: 0x002D4FEF
		public unsafe int ComponentNumSubsections
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeInfo.__PropertyOffset_ComponentNumSubsections);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeInfo.__PropertyOffset_ComponentNumSubsections) = value;
			}
		}

		// Token: 0x170079A1 RID: 31137
		// (get) Token: 0x0601E912 RID: 125202 RVA: 0x002D6E00 File Offset: 0x002D5000
		// (set) Token: 0x0601E913 RID: 125203 RVA: 0x002D6E14 File Offset: 0x002D5014
		public unsafe FVector DrawScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULandscapeInfo.__PropertyOffset_DrawScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULandscapeInfo.__PropertyOffset_DrawScale) = value;
			}
		}

		// Token: 0x170079A2 RID: 31138
		// (get) Token: 0x0601E914 RID: 125204 RVA: 0x002D6E2C File Offset: 0x002D502C
		// (set) Token: 0x0601E915 RID: 125205 RVA: 0x002D6E65 File Offset: 0x002D5065
		public TArray<ALandscapeStreamingProxy> Proxies
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ALandscapeStreamingProxy> result;
				if ((result = this._Proxies) == null)
				{
					result = (this._Proxies = new TArray<ALandscapeStreamingProxy>(base.NativePtr + (IntPtr)ULandscapeInfo.__PropertyOffset_Proxies, this));
				}
				return result;
			}
			set
			{
				this.Proxies.CopyAssign(value);
			}
		}

		// Token: 0x0601E916 RID: 125206 RVA: 0x002D6E73 File Offset: 0x002D5073
		static ULandscapeInfo()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Landscape.LandscapeInfo");
		}

		// Token: 0x0601E917 RID: 125207 RVA: 0x002D6E81 File Offset: 0x002D5081
		protected ULandscapeInfo(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010848 RID: 67656
		public new const string __ObjectPath = "/Script/Landscape.LandscapeInfo";

		// Token: 0x04010849 RID: 67657
		private static IntPtr _ClassPtr;

		// Token: 0x0401084A RID: 67658
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401084B RID: 67659
		internal static int __PropertyOffset_LandscapeActor;

		// Token: 0x0401084C RID: 67660
		internal static int __PropertyOffset_LandscapeGuid;

		// Token: 0x0401084D RID: 67661
		internal static int __PropertyOffset_ComponentSizeQuads;

		// Token: 0x0401084E RID: 67662
		internal static int __PropertyOffset_SubsectionSizeQuads;

		// Token: 0x0401084F RID: 67663
		internal static int __PropertyOffset_ComponentNumSubsections;

		// Token: 0x04010850 RID: 67664
		internal static int __PropertyOffset_DrawScale;

		// Token: 0x04010851 RID: 67665
		internal static int __PropertyOffset_Proxies;

		// Token: 0x04010852 RID: 67666
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ALandscapeStreamingProxy> _Proxies;
	}
}
