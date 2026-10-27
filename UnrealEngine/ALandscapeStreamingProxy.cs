using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F91 RID: 8081
	[UnrealObjectPath("/Script/Landscape.LandscapeStreamingProxy")]
	[UnrealStructLayout(2592, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2592)]
	public class ALandscapeStreamingProxy : ALandscapeProxy, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601EB02 RID: 125698 RVA: 0x002D9E66 File Offset: 0x002D8066
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ALandscapeStreamingProxy._ClassPtr;
		}

		// Token: 0x0601EB03 RID: 125699 RVA: 0x002D9E74 File Offset: 0x002D8074
		public ALandscapeStreamingProxy() : this(BuiltinUtils.AllocNativeUObject(ALandscapeStreamingProxy.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EB04 RID: 125700 RVA: 0x002D9E9C File Offset: 0x002D809C
		[NullableContext(1)]
		public ALandscapeStreamingProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ALandscapeStreamingProxy.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007A40 RID: 31296
		// (get) Token: 0x0601EB05 RID: 125701 RVA: 0x002D9ECF File Offset: 0x002D80CF
		// (set) Token: 0x0601EB06 RID: 125702 RVA: 0x002D9EE3 File Offset: 0x002D80E3
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
				return *(base.NativePtr + (IntPtr)ALandscapeStreamingProxy.__PropertyOffset_LandscapeActor);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)ALandscapeStreamingProxy.__PropertyOffset_LandscapeActor) = value;
			}
		}

		// Token: 0x0601EB07 RID: 125703 RVA: 0x002D9EF8 File Offset: 0x002D80F8
		static ALandscapeStreamingProxy()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Landscape.LandscapeStreamingProxy");
		}

		// Token: 0x0601EB08 RID: 125704 RVA: 0x002D9F06 File Offset: 0x002D8106
		protected ALandscapeStreamingProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010973 RID: 67955
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Landscape.LandscapeStreamingProxy";

		// Token: 0x04010974 RID: 67956
		private static IntPtr _ClassPtr;

		// Token: 0x04010975 RID: 67957
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010976 RID: 67958
		internal static int __PropertyOffset_LandscapeActor;
	}
}
