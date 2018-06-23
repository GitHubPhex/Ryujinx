using System;

namespace Ryujinx.Graphics.Gal.Shader.SPIRV
{
    public class BinaryForm
    {
        public const uint MagicNumber = 0x07230203;
        
        public const uint VersionNumber = 0x00010000;

        // I don't think Khronos would give us an Id
        public const uint GeneratorMagicNumber = 0;
    }

    // https://github.com/KhronosGroup/SPIRV-Headers/blob/master/include/spirv/unified1/spirv.h
    public enum SourceLanguage
    {
        Unknown = 0,
    	ESSL = 1,
        GLSL = 2,
        OpenCL_C = 3,
        OpenCL_CPP = 4,
        HLSL = 5,
        Max = 0x7fffffff,
    }

    public enum ExecutionModel
    {
        Vertex = 0,
        TessellationControl = 1,
        TessellationEvaluation = 2,
        Geometry = 3,
        Fragment = 4,
        GLCompute = 5,
        Kernel = 6,
        Max = 0x7fffffff,
    }

    public enum AddressingModel
    {
        Logical = 0,
        Physical32 = 1,
        Physical64 = 2,
        Max = 0x7fffffff,
    }

    public enum MemoryModel
    {
        Simple = 0,
        GLSL450 = 1,
        OpenCL = 2,
        Max = 0x7fffffff,
    }

    public enum ExecutionMode
    {
        Invocations = 0,
        SpacingEqual = 1,
        SpacingFractionalEven = 2,
        SpacingFractionalOdd = 3,
        VertexOrderCw = 4,
        VertexOrderCcw = 5,
        PixelCenterInteger = 6,
        OriginUpperLeft = 7,
        OriginLowerLeft = 8,
        EarlyFragmentTests = 9,
        PointMode = 10,
        Xfb = 11,
        DepthReplacing = 12,
        DepthGreater = 14,
        DepthLess = 15,
        DepthUnchanged = 16,
        LocalSize = 17,
        LocalSizeHint = 18,
        InputPoints = 19,
        InputLines = 20,
        InputLinesAdjacency = 21,
        Triangles = 22,
        InputTrianglesAdjacency = 23,
        Quads = 24,
        Isolines = 25,
        OutputVertices = 26,
        OutputPoints = 27,
        OutputLineStrip = 28,
        OutputTriangleStrip = 29,
        VecTypeHint = 30,
        ContractionOff = 31,
        Initializer = 33,
        Finalizer = 34,
        SubgroupSize = 35,
        SubgroupsPerWorkgroup = 36,
        SubgroupsPerWorkgroupId = 37,
        LocalSizeId = 38,
        LocalSizeHintId = 39,
        PostDepthCoverage = 4446,
        StencilRefReplacingEXT = 5027,
        Max = 0x7fffffff,
    }

    public enum StorageClass
    {
        UniformConstant = 0,
        Input = 1,
        Uniform = 2,
        Output = 3,
        Workgroup = 4,
        CrossWorkgroup = 5,
        Private = 6,
        Function = 7,
        Generic = 8,
        PushConstant = 9,
        AtomicCounter = 10,
        Image = 11,
        StorageBuffer = 12,
        Max = 0x7fffffff,
    }

    public enum Dim
    {
        Dim1D = 0,
        Dim2D = 1,
        Dim3D = 2,
        Cube = 3,
        Rect = 4,
        Buffer = 5,
        SubpassData = 6,
        Max = 0x7fffffff,
    }

    public enum SamplerAddressingMode
    {
        None = 0,
        ClampToEdge = 1,
        Clamp = 2,
        Repeat = 3,
        RepeatMirrored = 4,
        Max = 0x7fffffff,
    }

    public enum SamplerFilterMode
    {
        Nearest = 0,
        Linear = 1,
        Max = 0x7fffffff,
    }

    public enum ImageFormat
    {
        Unknown = 0,
        Rgba32f = 1,
        Rgba16f = 2,
        R32f = 3,
        Rgba8 = 4,
        Rgba8Snorm = 5,
        Rg32f = 6,
        Rg16f = 7,
        R11fG11fB10f = 8,
        R16f = 9,
        Rgba16 = 10,
        Rgb10A2 = 11,
        Rg16 = 12,
        Rg8 = 13,
        R16 = 14,
        R8 = 15,
        Rgba16Snorm = 16,
        Rg16Snorm = 17,
        Rg8Snorm = 18,
        R16Snorm = 19,
        R8Snorm = 20,
        Rgba32i = 21,
        Rgba16i = 22,
        Rgba8i = 23,
        R32i = 24,
        Rg32i = 25,
        Rg16i = 26,
        Rg8i = 27,
        R16i = 28,
        R8i = 29,
        Rgba32ui = 30,
        Rgba16ui = 31,
        Rgba8ui = 32,
        R32ui = 33,
        Rgb10a2ui = 34,
        Rg32ui = 35,
        Rg16ui = 36,
        Rg8ui = 37,
        R16ui = 38,
        R8ui = 39,
        Max = 0x7fffffff,
    }

    public enum ImageChannelOrder
    {
        R = 0,
        A = 1,
        RG = 2,
        RA = 3,
        RGB = 4,
        RGBA = 5,
        BGRA = 6,
        ARGB = 7,
        Intensity = 8,
        Luminance = 9,
        Rx = 10,
        RGx = 11,
        RGBx = 12,
        Depth = 13,
        DepthStencil = 14,
        sRGB = 15,
        sRGBx = 16,
        sRGBA = 17,
        sBGRA = 18,
        ABGR = 19,
        Max = 0x7fffffff,
    }

    public enum ImageChannelDataType
    {
        SnormInt8 = 0,
        SnormInt16 = 1,
        UnormInt8 = 2,
        UnormInt16 = 3,
        UnormShort565 = 4,
        UnormShort555 = 5,
        UnormInt101010 = 6,
        SignedInt8 = 7,
        SignedInt16 = 8,
        SignedInt32 = 9,
        UnsignedInt8 = 10,
        UnsignedInt16 = 11,
        UnsignedInt32 = 12,
        HalfFloat = 13,
        Float = 14,
        UnormInt24 = 15,
        UnormInt101010_2 = 16,
        Max = 0x7fffffff,
    }

    public enum ImageOperandsShift
    {
        BiasShift = 0,
        LodShift = 1,
        GradShift = 2,
        ConstOffsetShift = 3,
        OffsetShift = 4,
        ConstOffsetsShift = 5,
        SampleShift = 6,
        MinLodShift = 7,
        Max = 0x7fffffff,
    }

    [Flags]
    public enum ImageOperands
    {
        None = 0,
        Bias = 0x00000001,
        Lod = 0x00000002,
        Grad = 0x00000004,
        ConstOffset = 0x00000008,
        Offset = 0x00000010,
        ConstOffsets = 0x00000020,
        Sample = 0x00000040,
        MinLod = 0x00000080,
    }

    [Flags]
    public enum FPFastMathMode
    {
        None = 0,
        NotNaN = 0x00000001,
        NotInf = 0x00000002,
        NSZ = 0x00000004,
        AllowRecip = 0x00000008,
        Fast = 0x00000010,
    }

    public enum FPRoundingMode
    {
        RTE = 0,
        RTZ = 1,
        RTP = 2,
        RTN = 3,
        Max = 0x7fffffff,
    }

    public enum LinkageType
    {
        Export = 0,
        Import = 1,
        Max = 0x7fffffff,
    }

    public enum AccessQualifier
    {
        ReadOnly = 0,
        WriteOnly = 1,
        ReadWrite = 2,
        Max = 0x7fffffff,
    }

    public enum FunctionParameterAttribute
    {
        Zext = 0,
        Sext = 1,
        ByVal = 2,
        Sret = 3,
        NoAlias = 4,
        NoCapture = 5,
        NoWrite = 6,
        NoReadWrite = 7,
        Max = 0x7fffffff,
    }

    public enum Decoration
    {
        RelaxedPrecision = 0,
        SpecId = 1,
        Block = 2,
        BufferBlock = 3,
        RowMajor = 4,
        ColMajor = 5,
        ArrayStride = 6,
        MatrixStride = 7,
        GLSLShared = 8,
        GLSLPacked = 9,
        CPacked = 10,
        BuiltIn = 11,
        NoPerspective = 13,
        Flat = 14,
        Patch = 15,
        Centroid = 16,
        Sample = 17,
        Invariant = 18,
        Restrict = 19,
        Aliased = 20,
        Volatile = 21,
        Constant = 22,
        Coherent = 23,
        NonWritable = 24,
        NonReadable = 25,
        Uniform = 26,
        SaturatedConversion = 28,
        Stream = 29,
        Location = 30,
        Component = 31,
        Index = 32,
        Binding = 33,
        DescriptorSet = 34,
        Offset = 35,
        XfbBuffer = 36,
        XfbStride = 37,
        FuncParamAttr = 38,
        FPRoundingMode = 39,
        FPFastMathMode = 40,
        LinkageAttributes = 41,
        NoContraction = 42,
        InputAttachmentIndex = 43,
        Alignment = 44,
        MaxByteOffset = 45,
        AlignmentId = 46,
        MaxByteOffsetId = 47,
        ExplicitInterpAMD = 4999,
        OverrideCoverageNV = 5248,
        PassthroughNV = 5250,
        ViewportRelativeNV = 5252,
        SecondaryViewportRelativeNV = 5256,
        NonUniformEXT = 5300,
        HlslCounterBufferGOOGLE = 5634,
        HlslSemanticGOOGLE = 5635,
        Max = 0x7fffffff,
    }

    public enum BuiltIn
    {
        Position = 0,
        PointSize = 1,
        ClipDistance = 3,
        CullDistance = 4,
        VertexId = 5,
        InstanceId = 6,
        PrimitiveId = 7,
        InvocationId = 8,
        Layer = 9,
        ViewportIndex = 10,
        TessLevelOuter = 11,
        TessLevelInner = 12,
        TessCoord = 13,
        PatchVertices = 14,
        FragCoord = 15,
        PointCoord = 16,
        FrontFacing = 17,
        SampleId = 18,
        SamplePosition = 19,
        SampleMask = 20,
        FragDepth = 22,
        HelperInvocation = 23,
        NumWorkgroups = 24,
        WorkgroupSize = 25,
        WorkgroupId = 26,
        LocalInvocationId = 27,
        GlobalInvocationId = 28,
        LocalInvocationIndex = 29,
        WorkDim = 30,
        GlobalSize = 31,
        EnqueuedWorkgroupSize = 32,
        GlobalOffset = 33,
        GlobalLinearId = 34,
        SubgroupSize = 36,
        SubgroupMaxSize = 37,
        NumSubgroups = 38,
        NumEnqueuedSubgroups = 39,
        SubgroupId = 40,
        SubgroupLocalInvocationId = 41,
        VertexIndex = 42,
        InstanceIndex = 43,
        SubgroupEqMask = 4416,
        SubgroupEqMaskKHR = 4416,
        SubgroupGeMask = 4417,
        SubgroupGeMaskKHR = 4417,
        SubgroupGtMask = 4418,
        SubgroupGtMaskKHR = 4418,
        SubgroupLeMask = 4419,
        SubgroupLeMaskKHR = 4419,
        SubgroupLtMask = 4420,
        SubgroupLtMaskKHR = 4420,
        BaseVertex = 4424,
        BaseInstance = 4425,
        DrawIndex = 4426,
        DeviceIndex = 4438,
        ViewIndex = 4440,
        BaryCoordNoPerspAMD = 4992,
        BaryCoordNoPerspCentroidAMD = 4993,
        BaryCoordNoPerspSampleAMD = 4994,
        BaryCoordSmoothAMD = 4995,
        BaryCoordSmoothCentroidAMD = 4996,
        BaryCoordSmoothSampleAMD = 4997,
        BaryCoordPullModelAMD = 4998,
        FragStencilRefEXT = 5014,
        ViewportMaskNV = 5253,
        SecondaryPositionNV = 5257,
        SecondaryViewportMaskNV = 5258,
        PositionPerViewNV = 5261,
        ViewportMaskPerViewNV = 5262,
        FullyCoveredEXT = 5264,
        Max = 0x7fffffff,
    }

    [Flags]
    public enum SelectionControl
    {
        None = 0,
        Flatten = 0x00000001,
        DontFlatten = 0x00000002,
    }

    [Flags]
    public enum LoopControl
    {
        None = 0,
        Unroll = 0x00000001,
        DontUnroll = 0x00000002,
        DependencyInfinite = 0x00000004,
        DependencyLength = 0x00000008,
    }

    [Flags]
    public enum FunctionControl
    {
        None = 0,
        Inline = 0x00000001,
        DontInline = 0x00000002,
        Pure = 0x00000004,
        Const = 0x00000008,
    }

    [Flags]
    public enum MemorySemantics
    {
        None = 0,
        Acquire = 0x00000002,
        Release = 0x00000004,
        AcquireRelease = 0x00000008,
        SequentiallyConsistent = 0x00000010,
        UniformMemory = 0x00000040,
        SubgroupMemory = 0x00000080,
        WorkgroupMemory = 0x00000100,
        CrossWorkgroupMemory = 0x00000200,
        AtomicCounterMemory = 0x00000400,
        ImageMemory = 0x00000800,
    }

    [Flags]
    public enum MemoryAccess
    {
        None = 0,
        Volatile = 0x00000001,
        Aligned = 0x00000002,
        Nontemporal = 0x00000004,
    }

    public enum Scope
    {
        CrossDevice = 0,
        Device = 1,
        Workgroup = 2,
        Subgroup = 3,
        Invocation = 4,
        Max = 0x7fffffff,
    }

    public enum GroupOperation
    {
        Reduce = 0,
        InclusiveScan = 1,
        ExclusiveScan = 2,
        ClusteredReduce = 3,
        PartitionedReduceNV = 6,
        PartitionedInclusiveScanNV = 7,
        PartitionedExclusiveScanNV = 8,
        Max = 0x7fffffff,
    }

    public enum KernelEnqueueFlags
    {
        NoWait = 0,
        WaitKernel = 1,
        WaitWorkGroup = 2,
        Max = 0x7fffffff,
    }

    [Flags]
    public enum KernelProfilingInfo
    {
        None = 0,
        CmdExecTime = 0x00000001,
    }

    public enum Capability
    {
        Matrix = 0,
        Shader = 1,
        Geometry = 2,
        Tessellation = 3,
        Addresses = 4,
        Linkage = 5,
        Kernel = 6,
        Vector16 = 7,
        Float16Buffer = 8,
        Float16 = 9,
        Float64 = 10,
        Int64 = 11,
        Int64Atomics = 12,
        ImageBasic = 13,
        ImageReadWrite = 14,
        ImageMipmap = 15,
        Pipes = 17,
        Groups = 18,
        DeviceEnqueue = 19,
        LiteralSampler = 20,
        AtomicStorage = 21,
        Int16 = 22,
        TessellationPointSize = 23,
        GeometryPointSize = 24,
        ImageGatherExtended = 25,
        StorageImageMultisample = 27,
        UniformBufferArrayDynamicIndexing = 28,
        SampledImageArrayDynamicIndexing = 29,
        StorageBufferArrayDynamicIndexing = 30,
        StorageImageArrayDynamicIndexing = 31,
        ClipDistance = 32,
        CullDistance = 33,
        ImageCubeArray = 34,
        SampleRateShading = 35,
        ImageRect = 36,
        SampledRect = 37,
        GenericPointer = 38,
        Int8 = 39,
        InputAttachment = 40,
        SparseResidency = 41,
        MinLod = 42,
        Sampled1D = 43,
        Image1D = 44,
        SampledCubeArray = 45,
        SampledBuffer = 46,
        ImageBuffer = 47,
        ImageMSArray = 48,
        StorageImageExtendedFormats = 49,
        ImageQuery = 50,
        DerivativeControl = 51,
        InterpolationFunction = 52,
        TransformFeedback = 53,
        GeometryStreams = 54,
        StorageImageReadWithoutFormat = 55,
        StorageImageWriteWithoutFormat = 56,
        MultiViewport = 57,
        SubgroupDispatch = 58,
        NamedBarrier = 59,
        PipeStorage = 60,
        GroupNonUniform = 61,
        GroupNonUniformVote = 62,
        GroupNonUniformArithmetic = 63,
        GroupNonUniformBallot = 64,
        GroupNonUniformShuffle = 65,
        GroupNonUniformShuffleRelative = 66,
        GroupNonUniformClustered = 67,
        GroupNonUniformQuad = 68,
        SubgroupBallotKHR = 4423,
        DrawParameters = 4427,
        SubgroupVoteKHR = 4431,
        StorageBuffer16BitAccess = 4433,
        StorageUniformBufferBlock16 = 4433,
        StorageUniform16 = 4434,
        UniformAndStorageBuffer16BitAccess = 4434,
        StoragePushConstant16 = 4435,
        StorageInputOutput16 = 4436,
        DeviceGroup = 4437,
        MultiView = 4439,
        VariablePointersStorageBuffer = 4441,
        VariablePointers = 4442,
        AtomicStorageOps = 4445,
        SampleMaskPostDepthCoverage = 4447,
        Float16ImageAMD = 5008,
        ImageGatherBiasLodAMD = 5009,
        FragmentMaskAMD = 5010,
        StencilExportEXT = 5013,
        ImageReadWriteLodAMD = 5015,
        SampleMaskOverrideCoverageNV = 5249,
        GeometryShaderPassthroughNV = 5251,
        ShaderViewportIndexLayerEXT = 5254,
        ShaderViewportIndexLayerNV = 5254,
        ShaderViewportMaskNV = 5255,
        ShaderStereoViewNV = 5259,
        PerViewAttributesNV = 5260,
        FragmentFullyCoveredEXT = 5265,
        GroupNonUniformPartitionedNV = 5297,
        ShaderNonUniformEXT = 5301,
        RuntimeDescriptorArrayEXT = 5302,
        InputAttachmentArrayDynamicIndexingEXT = 5303,
        UniformTexelBufferArrayDynamicIndexingEXT = 5304,
        StorageTexelBufferArrayDynamicIndexingEXT = 5305,
        UniformBufferArrayNonUniformIndexingEXT = 5306,
        SampledImageArrayNonUniformIndexingEXT = 5307,
        StorageBufferArrayNonUniformIndexingEXT = 5308,
        StorageImageArrayNonUniformIndexingEXT = 5309,
        InputAttachmentArrayNonUniformIndexingEXT = 5310,
        UniformTexelBufferArrayNonUniformIndexingEXT = 5311,
        StorageTexelBufferArrayNonUniformIndexingEXT = 5312,
        SubgroupShuffleINTEL = 5568,
        SubgroupBufferBlockIOINTEL = 5569,
        SubgroupImageBlockIOINTEL = 5570,
        Max = 0x7fffffff,
    }

    public enum OpCode
    {
        Nop = 0,
        Undef = 1,
        SourceContinued = 2,
        Source = 3,
        SourceExtension = 4,
        Name = 5,
        MemberName = 6,
        String = 7,
        Line = 8,
        Extension = 10,
        ExtInstImport = 11,
        ExtInst = 12,
        MemoryModel = 14,
        EntryPoint = 15,
        ExecutionMode = 16,
        Capability = 17,
        TypeVoid = 19,
        TypeBool = 20,
        TypeInt = 21,
        TypeFloat = 22,
        TypeVector = 23,
        TypeMatrix = 24,
        TypeImage = 25,
        TypeSampler = 26,
        TypeSampledImage = 27,
        TypeArray = 28,
        TypeRuntimeArray = 29,
        TypeStruct = 30,
        TypeOpaque = 31,
        TypePointer = 32,
        TypeFunction = 33,
        TypeEvent = 34,
        TypeDeviceEvent = 35,
        TypeReserveId = 36,
        TypeQueue = 37,
        TypePipe = 38,
        TypeForwardPointer = 39,
        ConstantTrue = 41,
        ConstantFalse = 42,
        Constant = 43,
        ConstantComposite = 44,
        ConstantSampler = 45,
        ConstantNull = 46,
        SpecConstantTrue = 48,
        SpecConstantFalse = 49,
        SpecConstant = 50,
        SpecConstantComposite = 51,
        SpecConstantOp = 52,
        Function = 54,
        FunctionParameter = 55,
        FunctionEnd = 56,
        FunctionCall = 57,
        Variable = 59,
        ImageTexelPointer = 60,
        Load = 61,
        Store = 62,
        CopyMemory = 63,
        CopyMemorySized = 64,
        AccessChain = 65,
        InBoundsAccessChain = 66,
        PtrAccessChain = 67,
        ArrayLength = 68,
        GenericPtrMemSemantics = 69,
        InBoundsPtrAccessChain = 70,
        Decorate = 71,
        MemberDecorate = 72,
        DecorationGroup = 73,
        GroupDecorate = 74,
        GroupMemberDecorate = 75,
        VectorExtractDynamic = 77,
        VectorInsertDynamic = 78,
        VectorShuffle = 79,
        CompositeConstruct = 80,
        CompositeExtract = 81,
        CompositeInsert = 82,
        CopyObject = 83,
        Transpose = 84,
        SampledImage = 86,
        ImageSampleImplicitLod = 87,
        ImageSampleExplicitLod = 88,
        ImageSampleDrefImplicitLod = 89,
        ImageSampleDrefExplicitLod = 90,
        ImageSampleProjImplicitLod = 91,
        ImageSampleProjExplicitLod = 92,
        ImageSampleProjDrefImplicitLod = 93,
        ImageSampleProjDrefExplicitLod = 94,
        ImageFetch = 95,
        ImageGather = 96,
        ImageDrefGather = 97,
        ImageRead = 98,
        ImageWrite = 99,
        Image = 100,
        ImageQueryFormat = 101,
        ImageQueryOrder = 102,
        ImageQuerySizeLod = 103,
        ImageQuerySize = 104,
        ImageQueryLod = 105,
        ImageQueryLevels = 106,
        ImageQuerySamples = 107,
        ConvertFToU = 109,
        ConvertFToS = 110,
        ConvertSToF = 111,
        ConvertUToF = 112,
        UConvert = 113,
        SConvert = 114,
        FConvert = 115,
        QuantizeToF16 = 116,
        ConvertPtrToU = 117,
        SatConvertSToU = 118,
        SatConvertUToS = 119,
        ConvertUToPtr = 120,
        PtrCastToGeneric = 121,
        GenericCastToPtr = 122,
        GenericCastToPtrExplicit = 123,
        Bitcast = 124,
        SNegate = 126,
        FNegate = 127,
        IAdd = 128,
        FAdd = 129,
        ISub = 130,
        FSub = 131,
        IMul = 132,
        FMul = 133,
        UDiv = 134,
        SDiv = 135,
        FDiv = 136,
        UMod = 137,
        SRem = 138,
        SMod = 139,
        FRem = 140,
        FMod = 141,
        VectorTimesScalar = 142,
        MatrixTimesScalar = 143,
        VectorTimesMatrix = 144,
        MatrixTimesVector = 145,
        MatrixTimesMatrix = 146,
        OuterProduct = 147,
        Dot = 148,
        IAddCarry = 149,
        ISubBorrow = 150,
        UMulExtended = 151,
        SMulExtended = 152,
        Any = 154,
        All = 155,
        IsNan = 156,
        IsInf = 157,
        IsFinite = 158,
        IsNormal = 159,
        SignBitSet = 160,
        LessOrGreater = 161,
        Ordered = 162,
        Unordered = 163,
        LogicalEqual = 164,
        LogicalNotEqual = 165,
        LogicalOr = 166,
        LogicalAnd = 167,
        LogicalNot = 168,
        Select = 169,
        IEqual = 170,
        INotEqual = 171,
        UGreaterThan = 172,
        SGreaterThan = 173,
        UGreaterThanEqual = 174,
        SGreaterThanEqual = 175,
        ULessThan = 176,
        SLessThan = 177,
        ULessThanEqual = 178,
        SLessThanEqual = 179,
        FOrdEqual = 180,
        FUnordEqual = 181,
        FOrdNotEqual = 182,
        FUnordNotEqual = 183,
        FOrdLessThan = 184,
        FUnordLessThan = 185,
        FOrdGreaterThan = 186,
        FUnordGreaterThan = 187,
        FOrdLessThanEqual = 188,
        FUnordLessThanEqual = 189,
        FOrdGreaterThanEqual = 190,
        FUnordGreaterThanEqual = 191,
        ShiftRightLogical = 194,
        ShiftRightArithmetic = 195,
        ShiftLeftLogical = 196,
        BitwiseOr = 197,
        BitwiseXor = 198,
        BitwiseAnd = 199,
        Not = 200,
        BitFieldInsert = 201,
        BitFieldSExtract = 202,
        BitFieldUExtract = 203,
        BitReverse = 204,
        BitCount = 205,
        DPdx = 207,
        DPdy = 208,
        Fwidth = 209,
        DPdxFine = 210,
        DPdyFine = 211,
        FwidthFine = 212,
        DPdxCoarse = 213,
        DPdyCoarse = 214,
        FwidthCoarse = 215,
        EmitVertex = 218,
        EndPrimitive = 219,
        EmitStreamVertex = 220,
        EndStreamPrimitive = 221,
        ControlBarrier = 224,
        MemoryBarrier = 225,
        AtomicLoad = 227,
        AtomicStore = 228,
        AtomicExchange = 229,
        AtomicCompareExchange = 230,
        AtomicCompareExchangeWeak = 231,
        AtomicIIncrement = 232,
        AtomicIDecrement = 233,
        AtomicIAdd = 234,
        AtomicISub = 235,
        AtomicSMin = 236,
        AtomicUMin = 237,
        AtomicSMax = 238,
        AtomicUMax = 239,
        AtomicAnd = 240,
        AtomicOr = 241,
        AtomicXor = 242,
        Phi = 245,
        LoopMerge = 246,
        SelectionMerge = 247,
        Label = 248,
        Branch = 249,
        BranchConditional = 250,
        Switch = 251,
        Kill = 252,
        Return = 253,
        ReturnValue = 254,
        Unreachable = 255,
        LifetimeStart = 256,
        LifetimeStop = 257,
        GroupAsyncCopy = 259,
        GroupWaitEvents = 260,
        GroupAll = 261,
        GroupAny = 262,
        GroupBroadcast = 263,
        GroupIAdd = 264,
        GroupFAdd = 265,
        GroupFMin = 266,
        GroupUMin = 267,
        GroupSMin = 268,
        GroupFMax = 269,
        GroupUMax = 270,
        GroupSMax = 271,
        ReadPipe = 274,
        WritePipe = 275,
        ReservedReadPipe = 276,
        ReservedWritePipe = 277,
        ReserveReadPipePackets = 278,
        ReserveWritePipePackets = 279,
        CommitReadPipe = 280,
        CommitWritePipe = 281,
        IsValidReserveId = 282,
        GetNumPipePackets = 283,
        GetMaxPipePackets = 284,
        GroupReserveReadPipePackets = 285,
        GroupReserveWritePipePackets = 286,
        GroupCommitReadPipe = 287,
        GroupCommitWritePipe = 288,
        EnqueueMarker = 291,
        EnqueueKernel = 292,
        GetKernelNDrangeSubGroupCount = 293,
        GetKernelNDrangeMaxSubGroupSize = 294,
        GetKernelWorkGroupSize = 295,
        GetKernelPreferredWorkGroupSizeMultiple = 296,
        RetainEvent = 297,
        ReleaseEvent = 298,
        CreateUserEvent = 299,
        IsValidEvent = 300,
        SetUserEventStatus = 301,
        CaptureEventProfilingInfo = 302,
        GetDefaultQueue = 303,
        BuildNDRange = 304,
        ImageSparseSampleImplicitLod = 305,
        ImageSparseSampleExplicitLod = 306,
        ImageSparseSampleDrefImplicitLod = 307,
        ImageSparseSampleDrefExplicitLod = 308,
        ImageSparseSampleProjImplicitLod = 309,
        ImageSparseSampleProjExplicitLod = 310,
        ImageSparseSampleProjDrefImplicitLod = 311,
        ImageSparseSampleProjDrefExplicitLod = 312,
        ImageSparseFetch = 313,
        ImageSparseGather = 314,
        ImageSparseDrefGather = 315,
        ImageSparseTexelsResident = 316,
        NoLine = 317,
        AtomicFlagTestAndSet = 318,
        AtomicFlagClear = 319,
        ImageSparseRead = 320,
        SizeOf = 321,
        TypePipeStorage = 322,
        ConstantPipeStorage = 323,
        CreatePipeFromPipeStorage = 324,
        GetKernelLocalSizeForSubgroupCount = 325,
        GetKernelMaxNumSubgroups = 326,
        TypeNamedBarrier = 327,
        NamedBarrierInitialize = 328,
        MemoryNamedBarrier = 329,
        ModuleProcessed = 330,
        ExecutionModeId = 331,
        DecorateId = 332,
        GroupNonUniformElect = 333,
        GroupNonUniformAll = 334,
        GroupNonUniformAny = 335,
        GroupNonUniformAllEqual = 336,
        GroupNonUniformBroadcast = 337,
        GroupNonUniformBroadcastFirst = 338,
        GroupNonUniformBallot = 339,
        GroupNonUniformInverseBallot = 340,
        GroupNonUniformBallotBitExtract = 341,
        GroupNonUniformBallotBitCount = 342,
        GroupNonUniformBallotFindLSB = 343,
        GroupNonUniformBallotFindMSB = 344,
        GroupNonUniformShuffle = 345,
        GroupNonUniformShuffleXor = 346,
        GroupNonUniformShuffleUp = 347,
        GroupNonUniformShuffleDown = 348,
        GroupNonUniformIAdd = 349,
        GroupNonUniformFAdd = 350,
        GroupNonUniformIMul = 351,
        GroupNonUniformFMul = 352,
        GroupNonUniformSMin = 353,
        GroupNonUniformUMin = 354,
        GroupNonUniformFMin = 355,
        GroupNonUniformSMax = 356,
        GroupNonUniformUMax = 357,
        GroupNonUniformFMax = 358,
        GroupNonUniformBitwiseAnd = 359,
        GroupNonUniformBitwiseOr = 360,
        GroupNonUniformBitwiseXor = 361,
        GroupNonUniformLogicalAnd = 362,
        GroupNonUniformLogicalOr = 363,
        GroupNonUniformLogicalXor = 364,
        GroupNonUniformQuadBroadcast = 365,
        GroupNonUniformQuadSwap = 366,
        SubgroupBallotKHR = 4421,
        SubgroupFirstInvocationKHR = 4422,
        SubgroupAllKHR = 4428,
        SubgroupAnyKHR = 4429,
        SubgroupAllEqualKHR = 4430,
        SubgroupReadInvocationKHR = 4432,
        GroupIAddNonUniformAMD = 5000,
        GroupFAddNonUniformAMD = 5001,
        GroupFMinNonUniformAMD = 5002,
        GroupUMinNonUniformAMD = 5003,
        GroupSMinNonUniformAMD = 5004,
        GroupFMaxNonUniformAMD = 5005,
        GroupUMaxNonUniformAMD = 5006,
        GroupSMaxNonUniformAMD = 5007,
        FragmentMaskFetchAMD = 5011,
        FragmentFetchAMD = 5012,
        GroupNonUniformPartitionNV = 5296,
        SubgroupShuffleINTEL = 5571,
        SubgroupShuffleDownINTEL = 5572,
        SubgroupShuffleUpINTEL = 5573,
        SubgroupShuffleXorINTEL = 5574,
        SubgroupBlockReadINTEL = 5575,
        SubgroupBlockWriteINTEL = 5576,
        SubgroupImageBlockReadINTEL = 5577,
        SubgroupImageBlockWriteINTEL = 5578,
        DecorateStringGOOGLE = 5632,
        MemberDecorateStringGOOGLE = 5633,
        Max = 0x7fffffff,
    }

    // https://github.com/KhronosGroup/SPIRV-Headers/blob/master/include/spirv/unified1/GLSL.std.450.h
    public enum GLSLstd450
    {
        Bad = 0,              // Don't use

        Round = 1,
        RoundEven = 2,
        Trunc = 3,
        FAbs = 4,
        SAbs = 5,
        FSign = 6,
        SSign = 7,
        Floor = 8,
        Ceil = 9,
        Fract = 10,

        Radians = 11,
        Degrees = 12,
        Sin = 13,
        Cos = 14,
        Tan = 15,
        Asin = 16,
        Acos = 17,
        Atan = 18,
        Sinh = 19,
        Cosh = 20,
        Tanh = 21,
        Asinh = 22,
        Acosh = 23,
        Atanh = 24,
        Atan2 = 25,

        Pow = 26,
        Exp = 27,
        Log = 28,
        Exp2 = 29,
        Log2 = 30,
        Sqrt = 31,
        InverseSqrt = 32,

        Determinant = 33,
        MatrixInverse = 34,

        Modf = 35,            // second operand needs an OpVariable to write to
        ModfStruct = 36,      // no OpVariable operand
        FMin = 37,
        UMin = 38,
        SMin = 39,
        FMax = 40,
        UMax = 41,
        SMax = 42,
        FClamp = 43,
        UClamp = 44,
        SClamp = 45,
        FMix = 46,
        IMix = 47,            // Reserved
        Step = 48,
        SmoothStep = 49,

        Fma = 50,
        Frexp = 51,            // second operand needs an OpVariable to write to
        FrexpStruct = 52,      // no OpVariable operand
        Ldexp = 53,

        PackSnorm4x8 = 54,
        PackUnorm4x8 = 55,
        PackSnorm2x16 = 56,
        PackUnorm2x16 = 57,
        PackHalf2x16 = 58,
        PackDouble2x32 = 59,
        UnpackSnorm2x16 = 60,
        UnpackUnorm2x16 = 61,
        UnpackHalf2x16 = 62,
        UnpackSnorm4x8 = 63,
        UnpackUnorm4x8 = 64,
        UnpackDouble2x32 = 65,

        Length = 66,
        Distance = 67,
        Cross = 68,
        Normalize = 69,
        FaceForward = 70,
        Reflect = 71,
        Refract = 72,

        FindILsb = 73,
        FindSMsb = 74,
        FindUMsb = 75,

        InterpolateAtCentroid = 76,
        InterpolateAtSample = 77,
        InterpolateAtOffset = 78,

        NMin = 79,
        NMax = 80,
        NClamp = 81,

        Count
    }
}