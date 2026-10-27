using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002779 RID: 10105
	[UnrealObjectPath("/Script/SimplygonUObjects.AmbientOcclusionVertexColorCaster")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UAmbientOcclusionVertexColorCaster : UBaseColorVertexColorCaster, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025C6C RID: 154732 RVA: 0x00394496 File Offset: 0x00392696
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAmbientOcclusionVertexColorCaster._ClassPtr;
		}

		// Token: 0x06025C6D RID: 154733 RVA: 0x003944A4 File Offset: 0x003926A4
		public UAmbientOcclusionVertexColorCaster() : this(BuiltinUtils.AllocNativeUObject(UAmbientOcclusionVertexColorCaster.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025C6E RID: 154734 RVA: 0x003944CC File Offset: 0x003926CC
		[NullableContext(1)]
		public UAmbientOcclusionVertexColorCaster(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAmbientOcclusionVertexColorCaster.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06025C6F RID: 154735 RVA: 0x003944FF File Offset: 0x003926FF
		static UAmbientOcclusionVertexColorCaster()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SimplygonUObjects.AmbientOcclusionVertexColorCaster");
		}

		// Token: 0x06025C70 RID: 154736 RVA: 0x0039450D File Offset: 0x0039270D
		protected UAmbientOcclusionVertexColorCaster(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401490B RID: 84235
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SimplygonUObjects.AmbientOcclusionVertexColorCaster";

		// Token: 0x0401490C RID: 84236
		private static IntPtr _ClassPtr;

		// Token: 0x0401490D RID: 84237
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
