using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020027D3 RID: 10195
	[UnrealObjectPath("/Script/SimplygonUObjects.RoughnessVertexColorCaster")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class URoughnessVertexColorCaster : UBaseColorVertexColorCaster, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026095 RID: 155797 RVA: 0x0039B076 File Offset: 0x00399276
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URoughnessVertexColorCaster._ClassPtr;
		}

		// Token: 0x06026096 RID: 155798 RVA: 0x0039B084 File Offset: 0x00399284
		public URoughnessVertexColorCaster() : this(BuiltinUtils.AllocNativeUObject(URoughnessVertexColorCaster.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026097 RID: 155799 RVA: 0x0039B0AC File Offset: 0x003992AC
		[NullableContext(1)]
		public URoughnessVertexColorCaster(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URoughnessVertexColorCaster.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06026098 RID: 155800 RVA: 0x0039B0DF File Offset: 0x003992DF
		static URoughnessVertexColorCaster()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SimplygonUObjects.RoughnessVertexColorCaster");
		}

		// Token: 0x06026099 RID: 155801 RVA: 0x0039B0ED File Offset: 0x003992ED
		protected URoughnessVertexColorCaster(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014C4B RID: 85067
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SimplygonUObjects.RoughnessVertexColorCaster";

		// Token: 0x04014C4C RID: 85068
		private static IntPtr _ClassPtr;

		// Token: 0x04014C4D RID: 85069
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
